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

            //Subscribe to Settings Change events
            mySettings.SettingsChangedEvent += MySettings_SettingsChangedEvent;

            //Load Setting object
            LoadSettingValues();

            ScanBaseFolder();
        }


        private void LoadSettingValues()
        {
            //Load all of the settings
            mySettings.LoadSettings();
            //Populate the entire Setting Screen
            this.tbSettings_BaseFolder.Text = mySettings.BaseFolder;
            this.tbSettings_DescriptionFile.Text = mySettings.DescriptionFile;

        }
        private void MySettings_SettingsChangedEvent(object sender, SettingsEventArg e)
        {
            
            switch (e.Key)
            {
                case "BaseFolder":
                    this.tbSettings_BaseFolder.Text = mySettings.BaseFolder;
                    break;
                case "DescriptionFile":
                    this.tbSettings_DescriptionFile.Text = mySettings.DescriptionFile;
                    break;
                default:
                    break;
            }
        }



        private void LoadTreeView(TreeView tree)
        {
            // Scan Base Folder for any folders and check in subfolders for Description.txt 
            // to indicate it is a Episode folder
            //
            //DirectoryInfo di = new DirectoryInfo(mySettings.BaseFolder);




        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            mySettings.UpdateSettings();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            switch (result)
            {
                case DialogResult.OK:
                    mySettings.BaseFolder = folderBrowserDialog1.SelectedPath;
                    break;
                default:
                    break;
            }
        }



        private void TbSettings_DescriptionFile_Leave1(object sender, System.EventArgs e)
        {
            //when we leave the edit field we check to see if it is differnt from the settings file;
            if (tbSettings_DescriptionFile.Text.ToUpper().Trim() != mySettings.DescriptionFile.ToUpper().Trim())
            {
                //Update the settings object if differnt.
                mySettings.DescriptionFile = tbSettings_DescriptionFile.Text;
            }
        }

        private void AddNode(TreeNode node)
        {
            //treeView1.Nodes.Add(node);
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

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mySettings.UpdateSettings();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Exit Application

            if (mySettings.IsDirty)
            {
                //if settings need saving then prompt for save.
                DialogResult result = MessageBox.Show("Settings have not been Save do you wish to save before exiting", "Unsave Settings", MessageBoxButtons.YesNoCancel);
                switch (result)
                {
                    case DialogResult.Cancel:
                        break;
                    case DialogResult.Yes:
                        mySettings.UpdateSettings();
                        Application.Exit();
                        break;
                    case DialogResult.No:
                        Application.Exit();
                        break;
                    default:
                        Application.Exit();
                        break;
                }
            }
            else
            {
                Application.Exit();
            }
        }

        private void ScanBaseFolder()
        {
            //Get base folder from seetings.
            DirectoryInfo di = new DirectoryInfo(mySettings.BaseFolder);
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
    }
}
