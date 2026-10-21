namespace Sube2.HelloWindowsApp
{
    partial class frmToplam
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
            btnVal1 = new Button();
            btnVal2 = new Button();
            btnVal3 = new Button();
            btnSum = new Button();
            SuspendLayout();
            // 
            // btnVal1
            // 
            btnVal1.Location = new Point(125, 74);
            btnVal1.Name = "btnVal1";
            btnVal1.Size = new Size(75, 23);
            btnVal1.TabIndex = 0;
            btnVal1.UseVisualStyleBackColor = true;
            btnVal1.Click += btn_Click;
            // 
            // btnVal2
            // 
            btnVal2.Location = new Point(125, 103);
            btnVal2.Name = "btnVal2";
            btnVal2.Size = new Size(75, 23);
            btnVal2.TabIndex = 1;
            btnVal2.UseVisualStyleBackColor = true;
            btnVal2.Click += btn_Click;
            // 
            // btnVal3
            // 
            btnVal3.Location = new Point(125, 132);
            btnVal3.Name = "btnVal3";
            btnVal3.Size = new Size(75, 23);
            btnVal3.TabIndex = 2;
            btnVal3.UseVisualStyleBackColor = true;
            btnVal3.Click += btn_Click;
            // 
            // btnSum
            // 
            btnSum.Location = new Point(103, 161);
            btnSum.Name = "btnSum";
            btnSum.Size = new Size(123, 43);
            btnSum.TabIndex = 3;
            btnSum.Text = "Sonucu Göster";
            btnSum.UseVisualStyleBackColor = true;
            btnSum.Click += btnSum_Click;
            // 
            // frmToplam
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 290);
            Controls.Add(btnSum);
            Controls.Add(btnVal3);
            Controls.Add(btnVal2);
            Controls.Add(btnVal1);
            Name = "frmToplam";
            Text = "frmToplam";
            Load += frmToplam_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnVal1;
        private Button btnVal2;
        private Button btnVal3;
        private Button btnSum;
    }
}