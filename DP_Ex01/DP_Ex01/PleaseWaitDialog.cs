using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace DP_Ex01
{
    class PleaseWaitDialog : Form
    {
        private Label labelPleaseWait;

        public PleaseWaitDialog(Form i_ParentForm)
        {
            InitializeComponent();
            this.Text = "Loading data, please wait...";
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(i_ParentForm.Location.X, i_ParentForm.Location.Y);
        }

        private void InitializeComponent()
        {
            this.labelPleaseWait = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPleaseWait
            // 
            this.labelPleaseWait.AutoSize = true;
            this.labelPleaseWait.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.labelPleaseWait.Location = new System.Drawing.Point(12, 18);
            this.labelPleaseWait.Name = "labelPleaseWait";
            this.labelPleaseWait.Size = new System.Drawing.Size(202, 19);
            this.labelPleaseWait.TabIndex = 0;
            this.labelPleaseWait.Text = "Loading data, please wait...";
            this.labelPleaseWait.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PleaseWaitForm
            // 
            this.ClientSize = new System.Drawing.Size(226, 57);
            this.Controls.Add(this.labelPleaseWait);
            this.Name = "PleaseWaitForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
