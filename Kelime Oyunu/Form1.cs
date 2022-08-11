using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kelime_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string kelimeGetir()
        {
            string[] kelimelerArray = new string[]
            {
                "Ramazan", "Masa", "Kitap", "Deneme", "Telefon", "Miyop", "Karton", "Buzdolabı",
                "Çanta", "Mandalina", "Kibirli", "Bilinçsizlik", "Rekabetçilik", "Orantısız", 
                "Tartışmasız", "Muz Ağacı", "Tırnak Makası", "Hayvanat Bahçesi", "Masal Kitabı",
                "Teknokent", "Atatürk Üniversitesi", "Mahkeme", "Salıncak", "Bilgisayar", "Sandalye"
            };
            Random rastgele = new Random();
            int sayi = rastgele.Next(kelimelerArray.Length);
            return kelimelerArray[sayi];

        }
        public void temizle()
        {
            lblLetter1.Text = "";
            lblLetter2.Text = "";
            lblLetter3.Text = "";
            lblLetter4.Text = "";
            lblLetter5.Text = "";
            lblLetter6.Text = "";
            lblLetter7.Text = "";
            lblLetter8.Text = "";
            lblLetter9.Text = "";
            lblLetter10.Text = "";
            lblLetter11.Text = "";
            lblLetter12.Text = "";
            lblLetter13.Text = "";
            lblLetter14.Text = "";
            lblLetter15.Text = "";
            lblLetter16.Text = "";
            lblLetter17.Text = "";
            lblLetter18.Text = "";
            lblLetter19.Text = "";
            lblLetter20.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        public string kelimeX = "Empty";
        public int skor = 0;
        public int sureSaniye = 0;
        public int sureDakika = 0;
        bool formTasiniyor = false;
        Point baslangicNoktasi = new Point(0, 0);
        private void button1_Click(object sender, EventArgs e)
        {
            temizle();
            string kelime = kelimeGetir();
            kelimeX = kelime;
            int[] recent = new int[20];
            for(int t = 0; t < recent.Length; t++)
            {
                recent[t] = -1;
            }
            for(int i = 0; i<kelime.Length; i++)
            {
                char c;
                while(true)
                {
                    Random rastgele = new Random();
                    int sayi = rastgele.Next(kelime.Length); ///////
                    bool kontrol = false;
                    for(int j = 0; j< recent.Length; j++)
                    {
                        if(recent[j] == sayi)
                        {
                            kontrol = true;
                        }
                    }
                    if (kontrol == false)
                    {
                        recent[i] = sayi;
                        c = kelime[sayi];
                        break;
                    }
                }

                switch (i)
                    {
                    case 0:
                        lblLetter1.Text = Convert.ToString(c);
                        break;
                    case 1:
                        lblLetter2.Text = Convert.ToString(c);
                        break;
                    case 2:
                        lblLetter3.Text = Convert.ToString(c);
                        break;
                    case 3:
                        lblLetter4.Text = Convert.ToString(c);
                        break;
                    case 4:
                        lblLetter5.Text = Convert.ToString(c);
                        break;
                    case 5:
                        lblLetter6.Text = Convert.ToString(c);
                        break;
                    case 6:
                        lblLetter7.Text = Convert.ToString(c);
                        break;
                    case 7:
                        lblLetter8.Text = Convert.ToString(c);
                        break;
                    case 8:
                        lblLetter9.Text = Convert.ToString(c);
                        break;
                    case 9:
                        lblLetter10.Text = Convert.ToString(c);
                        break;
                    case 10:
                        lblLetter11.Text = Convert.ToString(c);
                        break;
                    case 11:
                        lblLetter12.Text = Convert.ToString(c);
                        break;
                    case 12:
                        lblLetter13.Text = Convert.ToString(c);
                        break;
                    case 13:
                        lblLetter14.Text = Convert.ToString(c);
                        break;
                    case 14:
                        lblLetter15.Text = Convert.ToString(c);
                        break;
                    case 15:
                        lblLetter16.Text = Convert.ToString(c);
                        break;
                    case 16:
                        lblLetter17.Text = Convert.ToString(c);
                        break;
                    case 17:
                        lblLetter18.Text = Convert.ToString(c);
                        break;
                    case 18:
                        lblLetter19.Text = Convert.ToString(c);
                        break;
                    case 19:
                        lblLetter20.Text = Convert.ToString(c);
                        break;
                }

            }
            timer1.Enabled = true;
            button1.Text = "Yeni Kelime Getir";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(kelimeX == "Empty" || kelimeX == "\0")
            {
                MessageBox.Show("Lütfen önce oyunu başlatınız...","Kelime Oyunu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(textBox1.Text == kelimeX)
                {
                    MessageBox.Show("Doğru kelimeyi buldunuz tebrikler !","Kelime Oyunu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    skor += 10;
                    lblSkor.Text = skor.ToString();
                    temizle();
                    timer1.Enabled = false;
                    timer1.Stop();
                }
                else
                {
                    MessageBox.Show("Doğru Kelimeyi Bulamadınız Tekrar Deneyiniz !", "Kelime Oyunu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = "0" + sureDakika.ToString() + ":" + sureSaniye.ToString();
            sureSaniye++;

            if(sureSaniye >= 60)
            {
                sureSaniye = 0;
                sureDakika = 1;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu uygulama Ramazan Harmaner Tarafından Geliştirimiştir.\n"+
                "İletişim E-mail adresi: ramazanharmaner@gmail.com\n"+
                "Sürüm: V0.0.1\n"+
                "Uygulama Adı: Kelime Oyunu", "Kelime Oyunu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            formTasiniyor = true;
            baslangicNoktasi = new Point(e.X, e.Y);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            formTasiniyor = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (formTasiniyor)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.baslangicNoktasi.X, p.Y - this.baslangicNoktasi.Y);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            temizle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Toplam Puanınız: " + skor.ToString() + "\n" +
                "Toplam Süre: 0" + sureDakika.ToString() + ":" + sureSaniye, "Kelime Oyunu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle();
        
        }
    }
}
