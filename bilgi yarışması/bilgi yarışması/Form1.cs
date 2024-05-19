using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Windows.Forms;
using System.Reflection.Emit;

namespace bilgi_yarışması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac=0;
        int puan = 0;
        int süre = 60;
        private void btnbaslat_Click(object sender, EventArgs e)
        {
            timer1.Start();
            sayac++;
            btnbaslat.Text = "Sonraki";

            btna.Enabled = true;
            btnb.Enabled = true;
            btnc.Enabled = true;
            btnd.Enabled = true;
            btnbaslat.Enabled = false;

            btna.BackColor = Color.Gray;
            btnb.BackColor = Color.Gray;
            btnc.BackColor = Color.Gray;
            btnd.BackColor = Color.Gray;



            if (sayac==1)
            {
                btna.Text = "Outbook";
                btnb.Text = "powerpoint";
                btnc.Text = "powerlook";
                btnd.Text = "outlook";
                richTextBox1.Text = "Mail, kişiler,etkinlik ve randevu gibi işlemleri kolayca yürütebilen Micro Soft programı aşağıdakilerden hangisidir?";
                lblcevap.Text = "outlook";

            }


            if (sayac == 2)
            {
                btna.Text = "0";
                btnb.Text = "1";
                btnc.Text = "2";
                btnd.Text = "128";
                richTextBox1.Text = "Dizilerde index değeri default olarak kaçtan başlar?";
                lblcevap.Text = "0";

            }


            if (sayac == 3)
            {
                btna.Text = "Garbage Collection";
                btnb.Text = "CLR";
                btnc.Text = "Base class library";
                btnd.Text = "CIL";
                richTextBox1.Text = "Aşağıdakilerden hangisi .NET framework içerisinde tanımlı değildir ?";
                lblcevap.Text = "CLR";

            }


            if (sayac == 4)
            {
                btna.Text = "Bilgisayar";
                btnb.Text = "İşletim Sistemi";
                btnc.Text = "Ana Bellek ";
                btnd.Text = "Anakart";
                richTextBox1.Text = "Kendisine verdiğimiz bilgileri istediğimizde saklayabilen,istediğimizde geri verebilen cihaza ne denir";
                lblcevap.Text = "Bilgisayar";

            }


            if (sayac == 5)
            {
                btna.Text = "Ram bellek";
                btnb.Text = "İşlemci";
                btnc.Text = "Sabit Disk ";
                btnd.Text = "Cvd/Dvd okuyucu";
                richTextBox1.Text = "Bilgisayara yüklenen bilgilerin depolandığı donanım birimi hangisidir";
                lblcevap.Text = "Sabit Disk ";

            }


            if (sayac == 6)
            {
                btna.Text = "Optik Okuyucu";
                btnb.Text = "Scanner (Tarayıcı)";
                btnc.Text = "Yazıcı ";
                btnd.Text = "Barkod Okuyucu ";
                richTextBox1.Text = "Aşağıdakilerden hangisi bir çıkış birimidir ";
                lblcevap.Text = "Yazıcı";

            }


            if (sayac == 7)
            {
                btna.Text = "Float";
                btnb.Text = "Decimal";
                btnc.Text = "String";
                btnd.Text = "Boolean";
                richTextBox1.Text = "Aşağıdakilerdem hangi iki değişken türü olarak doğru ve yanlışı temsil eder ";
                lblcevap.Text = "Boolean";

            }


            if (sayac == 8)
            {
                btna.Text = "Ubuntu ";
                btnb.Text = "Fedora";
                btnc.Text = "Red Hat";
                btnd.Text = "Debian";
                richTextBox1.Text = "Aşağıdakilerden hangisi bir işletim sistemi değildir ?";
                lblcevap.Text = "Red Hat";

            }


            if (sayac == 9)
            {
                btna.Text = "Mikro işlemci";
                btnb.Text = "Klavye";
                btnc.Text = "Pil";
                btnd.Text = "RAM";
                richTextBox1.Text = "Aşağıdakilerden hangisi anakartın üzerinde bulunmaz";
                lblcevap.Text = "RAM";

            }


            if (sayac == 10)
            {
                btna.Text = "Anadolu Aslanı";
                btnb.Text = "Anadolu Kaplanı";
                btnc.Text = "Anadolu Parsı";
                btnd.Text = "Anadolu Kurdu ";
                richTextBox1.Text = "Pardus'un anlamı aşağıdakilerden hangisidir";
                lblcevap.Text = "Anadolu Parsı";
                

            }
            if (sayac == 11)
            {
                puan = puan + Convert.ToInt32(lblsüre.Text);
                lblpuandegeri.Text = puan.ToString();
                btnbaslat.Text = "Bitir";
                btnbaslat.Enabled = true;

            }
            if (sayac == 12)
            {
                this.Close();
            }



        }

        private void btna_Click(object sender, EventArgs e)
        {
            lblcevap1.Text=btna.Text;
            if (lblcevap1.Text == lblcevap.Text)
            {
                puan = puan + 10;
                lblpuandegeri.Text=puan.ToString();
                btna.BackColor = Color.Green;
            }
            else
            {
                btna.BackColor = Color.Red;
            }

            btna.Enabled= false;
            btnb.Enabled=false;
            btnc.Enabled=false;
            btnd.Enabled=false;
            btnbaslat.Enabled = true;
        }

        private void btnb_Click(object sender, EventArgs e)
        {
            lblcevap1.Text = btnb.Text;
            if (lblcevap1.Text == lblcevap.Text)
            {
                puan = puan + 10;
                lblpuandegeri.Text = puan.ToString();
                btnb.BackColor = Color.Green;
            }
            else
            {
                btnb.BackColor = Color.Red;
            }

            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btnbaslat.Enabled = true;
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            lblcevap1.Text = btnc.Text;
            if (lblcevap1.Text == lblcevap.Text)
            {
                puan = puan + 10;
                lblpuandegeri.Text = puan.ToString();
                btnc.BackColor = Color.Green;
            }
            else
            {
                btnc.BackColor = Color.Red;
            }

            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btnbaslat.Enabled = true;
        }

        private void btnd_Click(object sender, EventArgs e)
        {
            lblcevap1.Text = btnd.Text;
            if (lblcevap1.Text == lblcevap.Text)
            {
                puan = puan + 10;
                lblpuandegeri.Text = puan.ToString();
                btnd.BackColor = Color.Green;
            }
            else
            {
                btnd.BackColor = Color.Red;
            }

            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btnbaslat.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btna.BackColor= Color.Gray;
            btnb.BackColor= Color.Gray;
            btnc.BackColor= Color.Gray;
            btnd.BackColor= Color.Gray;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            süre--;
            lblsüre.Text=süre.ToString();
            if (süre == 0)
            {
                timer1.Stop();  
            }
        }
    }
}