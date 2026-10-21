using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sube2.HelloWindowsApp
{
    public partial class frmToplam : Form
    {
        int toplam = 0;
        public frmToplam()
        {
            InitializeComponent();
        }

        private void frmToplam_Load(object sender, EventArgs e)
        {
            SayiUret();
        }

        void SayiUret()
        {
            var rnd = new Random();
            btnVal1.Text = rnd.Next(100).ToString();
            btnVal2.Text = rnd.Next(100).ToString();
            btnVal3.Text = rnd.Next(100).ToString();
        } //birden fazla sayı üretmek istediğimiz için methodu ekledik

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender; //SENDER VERİ TİPİ UYUŞMADIĞI İÇİN BUTONA ÇEVİRDİK VE BTN TİPİNDEKİ BUTONA ATADIK
            toplam += int.Parse(btn.Text);
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"İşlemin Sonucu:{toplam}");
            toplam = 0;
            SayiUret();
        }
    }
}
