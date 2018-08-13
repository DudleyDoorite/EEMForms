namespace EEMMain
{
    partial class FormSign
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelTitle = new System.Windows.Forms.Label();
            this.LabelExtra = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelTitle
            // 
            this.LabelTitle.Font = new System.Drawing.Font("Minercraftory", 72F);
            this.LabelTitle.Location = new System.Drawing.Point(12, 9);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(776, 149);
            this.LabelTitle.TabIndex = 0;
            this.LabelTitle.Text = "Available";
            this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LabelExtra
            // 
            this.LabelExtra.Font = new System.Drawing.Font("Minercraftory", 24F);
            this.LabelExtra.ForeColor = System.Drawing.Color.White;
            this.LabelExtra.Location = new System.Drawing.Point(12, 312);
            this.LabelExtra.Name = "LabelExtra";
            this.LabelExtra.Size = new System.Drawing.Size(776, 159);
            this.LabelExtra.TabIndex = 0;
            this.LabelExtra.Text = "Come on in, I\'m not busy.";
            this.LabelExtra.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormSign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.ControlBox = false;
            this.Controls.Add(this.LabelExtra);
            this.Controls.Add(this.LabelTitle);
            this.ForeColor = System.Drawing.Color.Lime;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSign";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormSign";
            this.TopMost = true;
            this.LocationChanged += new System.EventHandler(this.FormSign_LocationChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Label LabelExtra;
    }
}