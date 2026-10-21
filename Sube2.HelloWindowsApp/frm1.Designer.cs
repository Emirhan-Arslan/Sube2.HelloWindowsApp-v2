namespace Sube2.HelloWindowsApp
{
    partial class frm1
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
            btnKac = new Button();
            pnlinfo = new Panel();
            lblSkor = new Label();
            pnlinfo.SuspendLayout();
            SuspendLayout();
            // 
            // btnKac
            // 
            btnKac.Location = new Point(261, 103);
            btnKac.Name = "btnKac";
            btnKac.Size = new Size(187, 147);
            btnKac.TabIndex = 0;
            btnKac.Text = "button1";
            btnKac.UseVisualStyleBackColor = true;
            btnKac.SizeChanged += btnKac_SizeChanged;
            btnKac.MouseMove += button1_MouseMove;
            // 
            // pnlinfo
            // 
            pnlinfo.BackColor = Color.DarkGreen;
            pnlinfo.Controls.Add(lblSkor);
            pnlinfo.Location = new Point(561, 5);
            pnlinfo.Name = "pnlinfo";
            pnlinfo.Size = new Size(227, 444);
            pnlinfo.TabIndex = 1;
            pnlinfo.Paint += pnlinfo_Paint;
            // 
            // lblSkor
            // 
            lblSkor.AutoSize = true;
            lblSkor.Location = new Point(90, 115);
            lblSkor.Name = "lblSkor";
            lblSkor.Size = new Size(0, 20);
            lblSkor.TabIndex = 0;
            lblSkor.Click += label1_Click;
            // 
            // frm1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 454);
            Controls.Add(pnlinfo);
            Controls.Add(btnKac);
            Name = "frm1";
            Text = "frm1";
            Load += frm1_Load;
            MouseMove += frm1_MouseMove;
            pnlinfo.ResumeLayout(false);
            pnlinfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnKac;
        private Panel pnlinfo;
        private Label lblSkor;
    }
}