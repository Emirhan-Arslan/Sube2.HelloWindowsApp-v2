using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sube2.HelloWindowsApp
{
    public partial class foormToplam : Form
    {
        int toplam = 0;
        public foormToplam()
        {
            InitializeComponent();
            this.Load += frmToplam_Load;
        }

        private void frmToplam_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            btnVal1.Text = rnd.Next(1, 101).ToString();
            btnVal2.Text = rnd.Next(1, 101).ToString();
            btnVal3.Text = rnd.Next(1, 101).ToString();
        }

        private void btnVal1_Click(object sender, EventArgs e)
        {
            Button tiklananButon = (Button)sender;
            int tiklananSayi = int.Parse(tiklananButon.Text);

            toplam += tiklananSayi;
            btnSum.Text = toplam.ToString();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {

        }
    }
}
