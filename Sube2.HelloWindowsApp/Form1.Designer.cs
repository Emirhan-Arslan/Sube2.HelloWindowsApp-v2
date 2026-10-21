namespace Sube2.HelloWindowsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnHello = new Button();
            lblKoordinat = new Label();
            SuspendLayout();
            // 
            // btnHello
            // 
            btnHello.Location = new Point(379, 219);
            btnHello.Margin = new Padding(3, 4, 3, 4);
            btnHello.Name = "btnHello";
            btnHello.Size = new Size(150, 87);
            btnHello.TabIndex = 0;
            btnHello.Text = "Hello Windows!";
            btnHello.UseVisualStyleBackColor = true;
            btnHello.Click += MyButtonClick;
            btnHello.Move += button1_Move;
            // 
            // lblKoordinat
            // 
            lblKoordinat.AutoSize = true;
            lblKoordinat.Location = new Point(456, 128);
            lblKoordinat.Name = "lblKoordinat";
            lblKoordinat.Size = new Size(0, 20);
            lblKoordinat.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(lblKoordinat);
            Controls.Add(btnHello);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            SizeChanged += Form1_SizeChanged;
            MouseMove += Form1_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHello;
        private Label lblKoordinat;
    }
}
