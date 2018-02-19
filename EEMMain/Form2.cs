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
    public partial class Form2 : Form
    {
        public string NewFolder { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewFolder = tbNewFolder.Text;
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewFolder = string.Empty;
            this.Hide();
        }
    }
}
