using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sube2.HelloWindowsApp
{
    public partial class frm1 : Form
    {
        lblSkor = 0;

        public frm1()
        {
            InitializeComponent();
           

        }
        

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            //github için denemeeee
            //ClientSize.Width - pnlinfo.Width) - btnKac.Width //normal forumdan panelide çıkartarak buton çıkmasını engelledik dışına 
            var rnd = new Random();
            int x = rnd.Next((ClientSize.Width - pnlinfo.Width) - btnKac.Width); //this.Width dediğinde borderlarıda alıyoruz bu yüzden aşağıda kaçıyor bizde this with yerine clintsize dedik
            int y = rnd.Next(this.ClientSize.Height - btnKac.Height); //this yazsakta yazmasakta farketmez hiç bir farkı yok sadece okunurluğu artırmak neyin ClientSize diye
            btnKac.Location = new Point(x, y);
            pnlinfo.Location = new Point(ClientSize.Width - pnlinfo.Width, 0);
            pnlinfo.Height = ClientSize.Height;
            lblSkor++;
            lblSkor.Text= lblSkor.ToString();  
        
        }
        private void frm1_MouseMove(object sender, MouseEventArgs e)
        {
            btnKac.Text = $"X:{e.X} Y:{e.Y}";
        }

        private void pnlinfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm1_Load(object sender, EventArgs e)
        {

        }

        private void btnKac_SizeChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        { 
         
        }
    }
}
