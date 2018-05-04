using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace EEMMain
{
    public partial class Form1 : Form
    {
        EEMSettings mySettings = new EEMSettings();
        Episode curEpisode = new Episode();
        FormSign mySign = new FormSign();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Old Commented Code
            ////Step 1 Make a Folder
            //string _baseFolder = @"D:\Dev\Epiktetus\Sample";
            //string _game = "Space Engineers";
            //int _season = 0;
            //int _episode = 0;

            //String EpisodeDir = string.Format("{0}\\{1} S{2}E{3:00}", _baseFolder, _game, _season, _episode);
            ////String EpisodeDir = string.Format("{0} E{2}", _game, _season, _episode);

            //Directory.CreateDirectory(EpisodeDir);

            ////Step 2 Call Convertion Command
            #endregion

            //Load Setting object
            LoadSettingValues();
            ScanBaseFolder();


            //Create Events
            treeView1.AfterSelect += TreeView1_AfterSelect;
            this.LocationChanged += Form1_LocationChanged;
            this.SizeChanged += Form1_SizeChanged;
            this.FormClosed += Form1_FormClosed;


            //Load first episode
            TreeNode FirstNode = treeView1.Nodes[0];
            treeView1.SelectedNode = FirstNode;
        }

        private void Form1_FormClosed(object sender, EventArgs e)
        {
            notifyIcon.Dispose();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                mySettings.MainFormWidth = this.Width.ToString();
                mySettings.MainFormHeight = this.Height.ToString();
                mySettings.UpdateSettings();
            }
            else if (this.WindowState == FormWindowState.Minimized)
            {
                mySign.Location = new Point(1920, 0);
                mySign.Visible = true;
            }
        }

        private void Form1_LocationChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                mySettings.MainFormLocX = this.Location.X.ToString();
                mySettings.MainFormLocY = this.Location.Y.ToString();
                mySettings.UpdateSettings();
            }
        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (!string.IsNullOrEmpty(curEpisode.Path))
            {
                curEpisode.Title = tbTitle.Text;
                curEpisode.Description = tbDescription.Text;
                curEpisode.Tags = tbTags.Text;
                curEpisode.SaveGameFolder = tbSaveGameFolder.Text;
                curEpisode.FolderName = TSLFolderName.Text;            
                
                curEpisode.Save(curEpisode.Path);
            }


            //Open the episode.xml file
            string xmlFile = string.Format("{0}\\{1}\\{2}", mySettings.BaseFolder, e.Node.Text, mySettings.DescriptionFile);
            //Into our current episode object 
            curEpisode.Load(xmlFile);


            //and update the episode screen
            curEpisode.Path = xmlFile;
            curEpisode.FolderName = e.Node.Text;


            this.tbTitle.Text = curEpisode.Title;
            this.tbDescription.Text = curEpisode.Description;
            this.tbTags.Text = curEpisode.Tags;
            this.tbSaveGameFolder.Text = curEpisode.SaveGameFolder;
            this.TSLFolderName.Text = curEpisode.FolderName;
        }

        private void LoadSettingValues()
        {
            //Load all of the settings
            mySettings.LoadSettings();
            try
            {
                this.SetDesktopLocation(int.Parse(mySettings.MainFormLocX), int.Parse(mySettings.MainFormLocY));
                this.Width = int.Parse(mySettings.MainFormWidth);
                this.Height = int.Parse(mySettings.MainFormHeight);
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("Failure Setting Value : {0}", ex.Message));
            }
        }

        private void LoadTreeView(TreeView tree)
        {
        }

        private TreeNode MakeNode(string nodeName)
        {
            TreeNode tn = new TreeNode(nodeName);
            return tn;
        }

        private TreeNode AddChildNode(TreeNode parent, TreeNode child)
        {
            parent.Nodes.Add(child);
            return parent;
        }

        private void ScanBaseFolder()
        {
            //Get base folder from seetings.
            DirectoryInfo di = new DirectoryInfo(mySettings.BaseFolder);
            if (di.Exists)
            {
                
                IEnumerable<DirectoryInfo> dirList = di.EnumerateDirectories();
                treeView1.Nodes.Clear();
                foreach (DirectoryInfo dir in dirList)
                {
                    string checkfile = string.Format("{0}\\{1}", dir.FullName, mySettings.DescriptionFile);
                    if (File.Exists(checkfile))
                    {
                        treeView1.Nodes.Add(dir.Name);
                    }
                }
            }
            else
            {
                MessageBox.Show("Base Folder not Found: " + mySettings.BaseFolder, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void openInFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(string.Format("{0}\\{1}", mySettings.BaseFolder,curEpisode.FolderName));
        }

        private void archiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //lowest priority feature
            //move entire episode folder to a selected folder (default is Z:\EpikTek\seriesname\seasonname but this isn't predictable enough to do programatically)
            ScanBaseFolder();
        }

        private void pullFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //look in captures folder for *.mkv files
            string[] fileEntries = Directory.GetFiles(mySettings.CapturesFolder);
            string ext;
            //for each one execute this command:
            foreach (string fileName in fileEntries)
            {
                ext=Path.GetExtension(fileName);
                switch (ext)
                {
                    case ".mkv":
                        var process = System.Diagnostics.Process.Start("cmd.exe", "/c " + string.Format(mySettings.FFMpegPath, mySettings.BaseFolder, curEpisode.FolderName, Path.GetFileNameWithoutExtension(fileName), mySettings.CapturesFolder));
                        process.WaitForExit();
                        File.Move(fileName, mySettings.CapturesFolder + "\\done\\" + Path.GetFileName(fileName));
                        break;
                    case ".lnk":
                    case ".bat":
                        //skip shortcuts and batch files
                        break;
                    default:
                    File.Move(fileName, mySettings.BaseFolder +"\\"+ curEpisode.FolderName+"\\"+ Path.GetFileName(fileName));
                        break;
                }
            }
            

        }

        private void pullSaveGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //display a list of folders in the savegame folder for the selected episode.

            //the chosen subdir should then be compressed to a zip file and stored in the selected episode

            //the chosen subdir should be optionally deleted via yes/no dialog box
        }

        private void cloneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Ask what the new folder name is
            string newFolderName = Util.GetNextFolder(curEpisode.FolderName);
            string tmpNewFolderPath = string.Empty;

            if (string.IsNullOrEmpty(curEpisode.Path))
            {
                return; 
            }

            if (CustomInput.InputBox("Clone A Folder", "Enter the Name you want for the new folder", ref newFolderName) == DialogResult.OK)
            {
                //Add the new name to the base folder and create the new folder
                tmpNewFolderPath = string.Format("{0}\\{1}", mySettings.BaseFolder, newFolderName);
                //if the folder does not already exist
                if (!Directory.Exists(tmpNewFolderPath))
                {
                    //Create it
                    Directory.CreateDirectory(tmpNewFolderPath);
                }

                //TODO: We may want to warn user when a folder already exist before we copy the episode file into it.
                //If it does exit assume it only needs a episode file.
                //Create the destination file name and path
                string strDestinationDescriptionFile = string.Format("{0}\\{1}", tmpNewFolderPath, mySettings.DescriptionFile);
                //Verify it exist
                if (File.Exists(curEpisode.Path))
                {
                    //Copy source Episode file to new folder.
                    File.Copy(curEpisode.Path, strDestinationDescriptionFile);
                }
            }

            ScanBaseFolder();
        }

        private void TSBCopyFolderName_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.TSLFolderName.Text);
        }

        private void TSBCopyTitle_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.tbTitle.Text);
        }

        private void TSBCopyDesc_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.tbDescription.Text);
        }

        private void TSBCopyTags_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.tbTags.Text);
        }

        private void ButtonAvailable_Click(object sender, EventArgs e)
        {
            mySign.Hide();
            mySign.Location = new Point(1920,0);
            mySign.Show(this);
            mySign.SetAvailable();
        }

        private void ButtonRecording_Click(object sender, EventArgs e)
        {
            mySign.Hide();
            mySign.Location = new Point(1920, 0);
            mySign.Show(this);
            mySign.SetRecording();
        }

        private void ButtonStreaming_Click(object sender, EventArgs e)
        {
            mySign.Hide();
            mySign.Location = new Point(1920, 0);
            mySign.Show(this);
            mySign.SetStreaming();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/upload");
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Process OBS = new Process();
            OBS.Exited += OBS_Exited;
            OBS.StartInfo.FileName = "obs64.exe";
            OBS.StartInfo.WorkingDirectory = "C:\\Program Files (x86)\\obs-studio\\bin\\64bit\\";
            OBS.EnableRaisingEvents = true;
            OBS.Start();

            mySign.SetRecording();
        }


        private void OBS_Exited(object sender, EventArgs e)
        {
            //crashes with something about threads that I don't understand
            //mySign.SetAvailable();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("e:\\videos\\");
        }

        private void TSBSave_Click(object sender, EventArgs e)
        {
            curEpisode.Title = tbTitle.Text;
            curEpisode.Description = tbDescription.Text;
            curEpisode.Tags = tbTags.Text;
            curEpisode.SaveGameFolder = tbSaveGameFolder.Text;
            curEpisode.FolderName = TSLFolderName.Text;
            curEpisode.Save(curEpisode.Path);
        }

        private void TSBRevert_Click(object sender, EventArgs e)
        {
            curEpisode.Load(curEpisode.Path);
            this.tbTitle.Text = curEpisode.Title;
            this.tbDescription.Text = curEpisode.Description;
            this.tbTags.Text = curEpisode.Tags;
            this.tbSaveGameFolder.Text = curEpisode.SaveGameFolder;
            this.TSLFolderName.Text = curEpisode.FolderName;
        }

        private void TSLFolderName_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Path.GetDirectoryName(curEpisode.Path));
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                treeView1.SelectedNode = e.Node;
            }
        }

        private void CBOSignColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBOSignColor.BackColor = Color.FromName(CBOSignColor.Text);
            mySign.ChangeSign(Color.FromName(CBOSignColor.Text),TBSignTitle.Text,TBSignExtra.Text);
        }

        private void btnOpenSaveFolder_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(tbSaveGameFolder.Text);
        }

        private void notifyIcon_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                TrayMenu.Show();
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.Visible) 
            {
                this.Hide();
            }else{
                this.Show();
                this.Activate();
            }
        }
    }
}