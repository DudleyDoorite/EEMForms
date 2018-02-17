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
            ////Step 1 Make a Folder
            //string _baseFolder = @"D:\Dev\Epiktetus\Sample";
            //string _game = "Space Engineers";
            //int _season = 0;
            //int _episode = 0;

            //String EpisodeDir = string.Format("{0}\\{1} S{2}E{3:00}", _baseFolder, _game, _season, _episode);
            ////String EpisodeDir = string.Format("{0} E{2}", _game, _season, _episode);

            //Directory.CreateDirectory(EpisodeDir);

            ////Step 2 Call Convertion Command


            //Subscribe to Settings Change events
            mySettings.SettingsChangedEvent += MySettings_SettingsChangedEvent;

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
                case "DescriptionFolder":
                    this.tbSettings_DescriptionFile.Text = mySettings.DescriptionFile;
                    break;
                default:
                    break;
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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {

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
            DialogResult result =  folderBrowserDialog1.ShowDialog();
            switch (result)
            {
                case DialogResult.OK:
                    mySettings.BaseFolder = folderBrowserDialog1.SelectedPath;
                    break;
                default:
                    break;
            }
        }

      }
}
