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
                curEpisode.Save(curEpisode.Path);
            }


            //Open the episode.xml file
            string xmlFile = string.Format("{0}\\{1}\\{2}", mySettings.BaseFolder, e.Node.Text, mySettings.DescriptionFile);
            //Into our current episode object 
            curEpisode.Load(xmlFile);


            //and update the episode screen
            curEpisode.Path = xmlFile;
            this.tbTitle.Text = curEpisode.Title;
            this.tbDescription.Text = curEpisode.Description;
            this.tbTags.Text = curEpisode.Tags;
            this.tbSaveGameFolder.Text = curEpisode.SaveGameFolder;
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

                foreach (DirectoryInfo dir in dirList)
                {
                    string checkfile = string.Format("{0}\\{1}", dir.FullName, mySettings.DescriptionFile);
                    if (File.Exists(checkfile))
                    {
                        treeView1.Nodes.Add(dir.Name);
                    }
                }
            }
            else {
                MessageBox.Show("Base Folder not Found: " + mySettings.BaseFolder,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void pullFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cloneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Ask what the new folder name is

            //Add the new name to the base folder and create the new folder
            //Directory.CreateDirectory(string.Format("",mySettings.BaseFolder,newFolder)):


        }

        private void archiveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect_1(object sender, TreeViewEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

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
    }
}
