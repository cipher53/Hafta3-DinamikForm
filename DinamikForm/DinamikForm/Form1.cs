using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinamikForm
{
    // DinamikForm namespace'inde Form1 adında bir sınıf tanımlanıyor.
    public partial class Form1 : Form
    {
        // Film nesnelerini içeren bir List tanımlanıyor.
        public List<Film> filmler;

        // Form1 sınıfının kurucu metodu.
        public Form1()
        {
             // Form bileşenleri başlatılıyor.
            InitializeComponent();
             // Film.FilmleriListele metodu çağrılarak film listesi oluşturuluyor.
            filmler = Film.FilmleriListele();
        }

        // PictureBox nesnelerini ekrana yerleştiren metot.
        public void PictureBoxListele()
        {
            // PictureBox'ların yerleştirileceği başlangıç koordinatları tanımlanıyor.
            int x = 50;
            int y = 50;
            int xSonraki = 150;
            int ySonraki = 150;

            // PictureBox arka plan renkleri tanımlanıyor.
            var renk = new Color[] { Color.DarkBlue, Color.DarkCyan, 
                                    Color.DarkOliveGreen,Color.DarkOrange,
                                    Color.DarkMagenta,Color.DarkOrchid};

            // Belirli sayıda PictureBox oluşturuluyor.
            for (int i = 0; i < 5; i++)
            {
                // Belirli sayıda PictureBox oluşturuluyor.
                PictureBox pb = new PictureBox();
                // PictureBox'ın konumu belirleniyor.
                pb.Location = new Point(x, y);
                // PictureBox'ın arka plan rengi atanıyor.
                pb.BackColor = renk[i];
                // PictureBox'ın ismi FilmAdı ve kategoriye göre oluşturuluyor.
                pb.Name = filmler[i].FilmAdı + filmler[i].kategori;
                // PictureBox'a tıklandığında gerçekleşecek olay atanıyor.
                pb.Click += new EventHandler(pb_Click);

                // PictureBox formun kontrol listesine ekleniyor.
                this.Controls.Add(pb);

                // PictureBox'ların yerleştirilme koordinatları güncelleniyor.
                if (x < 250)
                {
                    x = x + xSonraki;
                }
                else {
                    x = 50;
                    y = y + ySonraki;
                }
            }
        }
        // PictureBox'a tıklandığında gerçekleşecek olay.
        private void pb_Click(object sender, EventArgs e)
        {
            // PictureBox nesnesi alınıyor.
            PictureBox picture = sender as PictureBox;
            // PictureBox'ın ismi MessageBox ile gösteriliyor.
            MessageBox.Show(picture.Name);
            
        }

        // Form yüklendiğinde gerçekleşecek olay.
        private void Form1_Load(object sender, EventArgs e)
        {
            // PictureBox'lar form yüklendiğinde listeleniyor.
            PictureBoxListele();
        }

    }
}
