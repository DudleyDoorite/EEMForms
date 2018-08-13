using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EEMMain
{
    public partial class FormSign : Form
    {
        public FormSign()
        {
            InitializeComponent();
        }

        public void ChangeSign (Color NewColor, string NewTitle, string NewExtra)
        {
            this.Hide();
            this.Location = new Point(1920, 0);
            LabelTitle.ForeColor = NewColor;
            LabelTitle.Text = NewTitle;
            LabelExtra.Text = NewExtra;
            this.Show();
        }

        public void SetAvailable ()
        {
            ChangeSign(Color.FromName("Lime"), "Available", "Come on in");
        }

        public void SetRecording()
        {
            ChangeSign(Color.FromName("Yellow"), "Recording", "Quietly open the door and wait for me to get to a good stopping point.");
        }

        public void SetStreaming()
        {
            ChangeSign(Color.FromName("Red"), "Streaming", "Only enter if it's important.");
        }

        private void FormSign_LocationChanged(object sender, EventArgs e)
        {
            if (this.Location == new Point(1920, 0))
            {
                //all good
            }
            else
            {
                this.Location = new Point(1920, 0);
            };
        }
    }

}
