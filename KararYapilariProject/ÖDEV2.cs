using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KararYapilariProject
{
    public partial class ÖDEV2 : Form
    {
        public ÖDEV2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Girilen not 0 - 30 araligi ise "FF" 30 - 50 araligi 
            //"DD" 50 - 70 "BB" 70 - 100 "AA" aldınız seklinde kullaniciyi uyariniz..


            int not = int.Parse(txtGiris.Text);

            if (not>=0 && not<=29)
            {
                txtCikis.Text = "Notunuz FF'dir";
            }
            else if(not>=30 && not<=49 )
            {
                txtCikis.Text = "Notunuz DD'dir";
            }
            else if (not>=50 && not<=69)
            {
                txtCikis.Text = "Notunuz BB'dir.";
            }
            else if (not>=70 && not<=100)
            {
                txtCikis.Text = "Notunuz AA'dir.";
            }
            else
            {
                txtCikis.Text = "Böyle bir NOT yok!!";
            }

            txtGiris.Clear();
            txtGiris.Focus();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Disaridan urun adi girilecek, kasiyer bize urunun 
            //hangi reyonda oldugunu soyleyecek...
            //Domates, Biber, Patlican => Sebze Reyonu
            //Diş Macunu, Parfüm, Şampuan => Kozmetik Reyonu
            //Cep Telefonu, Bilgisayar, Ses Sistemi => Teknoloji Reyonu
            //Başka bir ürün girilirse "Bu ürün bizde yok!" uyarisi verilsin!

            string products = txtGiris.Text.ToLower();

            switch (products)
            {
                case "domates":
                case "biber":
                case "patlıcan":
                case "salatalık":
                    MessageBox.Show("SEBZE REYONU");
                    break;
                case "diş macunu":
                case "parfüm":
                case "şampuan":
                    MessageBox.Show("KOZMETİK REYONU");
                    break;
                case "cep telefonu":
                case "bilgisayar":
                case "ses sistemi":
                    MessageBox.Show("TEKNOLOJİ REYONU");
                    break;
                default:
                    MessageBox.Show("BÖYLE BİR ÜRÜNÜ SATMIYORUZ");
                    break;
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Disaridan siparis alinacak olan kitap miktari girilsin.
            // Sipari sayisi 20'den azsa toplam ucretten %5, 20 - 50 araliginda ise %10,
            //50 -100 araligi ise %15, 100'den fazla ise %25 indirim yapilsin. 
            //Kitabın birim fiyatı => 5 TLdir... Amac => Odenecek tutari kullaniciya 
            //gostermek...

            
            int order = int.Parse(txtGiris.Text);
            int unitPrice = 5;
            double totalPrice = unitPrice * order;

            if (order<20)
            {
                MessageBox.Show((totalPrice * 0.95).ToString());
            }
            else if (order>=21 && order<=49)
            {
                MessageBox.Show((totalPrice * 0.90).ToString());
            }
            else if (order>=50 && order<=99)
            {
                MessageBox.Show((totalPrice * 0.85).ToString());
            }
            else if (order>=100)
            {
                MessageBox.Show((totalPrice * 0.75).ToString());
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
