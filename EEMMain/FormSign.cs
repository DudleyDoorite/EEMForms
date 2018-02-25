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
    }

}
