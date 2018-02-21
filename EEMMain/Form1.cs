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


namespace EEMMain
{
    public partial class Form1 : Form
    {
        EEMSettings mySettings = new EEMSettings();
        Episode curEpisode = new Episode();
        Form mySign = new FormSign();

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
        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (!string.IsNullOrEmpty(curEpisode.Path))
            {
                curEpisode.Title = tbTitle.Text;
                curEpisode.Description = tbDescription.Text;
                curEpisode.Tags = tbTags.Text;
                curEpisode.SaveGameFolder = tbSaveGameFolder.Text;
                curEpisode.FolderName = ""; //Replace this with a txt box on the episode screen                



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
            //TODO:Add Txt box load for Folder name
        }

        private void LoadSettingValues()
        {
            //Load all of the settings
            mySettings.LoadSettings();
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

        private void archiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //lowest priority feature
            //move entire episode folder to a selected folder (default is Z:\EpikTek\seriesname\seasonname but this isn't predictable enough to do programatically)
            ScanBaseFolder();
        }

        private void pullFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //look in captures folder for *.mkv files

            //for each one execute this command:
            //C:\Users\epikt\OneDrive\Apps\ffmpeg\bin\ffmpeg.exe -i "[filename].mkv" -c:v copy -c:a  pcm_s16le -map 0:0 -map 0:1 -map 0:2 -map 0:3 "[seledcted folder]\[filename].mov"

            //if all went well, delete the original file from the captures folder
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
            string newFolderName = curEpisode.FolderName;
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

        private void btnCopyTitle_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.tbTitle.Text);
        }

        private void btnCopyDesc_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.tbDescription.Text);
        }

        private void btnCopyTags_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.tbTags.Text);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void btnAvailable_Click(object sender, EventArgs e)
        {
            //show FormSign or replace it if one already exists.
            //might need to position to x=1920 y=0
            mySign.Show(this);
            mySign.Close();
        }
    }
}