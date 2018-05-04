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
            LabelTitle.ForeColor = NewColor;
            LabelTitle.Text = NewTitle;
            LabelExtra.Text = NewExtra;
        }

        public void SetAvailable ()
        {
            LabelTitle.ForeColor = Color.FromName("Lime");
            LabelTitle.Text = "Available"; 
            LabelExtra.Text = "Come on in, I'm not busy.";
        }

        public void SetRecording()
        {
            LabelTitle.ForeColor = Color.FromName("Yellow");
            LabelTitle.Text = "Recording";
            LabelExtra.Text = "Don't knock, just quietly open the door and wait for me to get to a good stopping point.";
        }

        public void SetStreaming()
        {
            LabelTitle.ForeColor = Color.FromName("Red");
            LabelTitle.Text = "Streaming";
            LabelExtra.Text = "Only enter if it's an emergency. It would be better to text me.";
        }
    }

}
