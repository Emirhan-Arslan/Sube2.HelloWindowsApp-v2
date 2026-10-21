namespace Sube2.HelloWindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var btn = new Button();
            btn.Text = "My Button!";
            btn.Location = new Point(100, 50);
            btn.Size = new Size(100, 100);
            btn.Click += MyButtonClick;
            this.Controls.Add(btn);
        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("My Button Clicked!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gazi Üniversitesi");
        }

        private void button1_Move(object sender, EventArgs e)
        {

        }

        private void MyButtonClick(object sender, EventArgs e)
        {
            Button buton = (Button)sender;
            MessageBox.Show(buton.Text);
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            btnHello.Location = new Point(btnHello.Location.X + 1, btnHello.Location.Y + 1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            lblKoordinat.Text = $"X:{e.X} Y:{e.Y}";
        }
    }
}

//Bir event tetiklendiğinde iş yapılabilmesi için, bir metod ile event'in ilişkilendirilmesi gerekir.
//Bir event'in method ile ilişkilenebilmesi için, metod imzasının uygun olması gerekir.
//Bir metod, birden fazla nesnenin eventleri ile ilişkilenebilir.
//sender: Event hangi nesne tarafından gönderilmişse, o nesnenin referansını tutar. Dolayısıyla nesneye erişebilir.
//Default Event: Bir control'e çift tıklayarak, bu event ile ilişkilenecek metod yazdırırlabilir.




//Properties kısmına girdiğinde hemen altındaki kutucuktan istediğimizi seçebiliriz mesela lblKoordinant gözükmüyor ekranda ordan bakıp seçerek üzerine işlem yapabiliriz name text değiştirmek için örneğin bunu uygulayabiliriz.

//fieldlarda get olmaz mouseEvents'ten f12 basıp kalıtımını gördük EventArgs olduğunu. propertylerini gördük şimdi
//event argsdan farklı görüyorsan e. bir şeyler getiriyor demek ki diyecez. 
//buton ayrı bir nesne olduğu için koordinat ile formu yazmadı buton üstündeki koordinatı tetikledi. Formun orjin noktası sol üst noktası 0,0 dır.