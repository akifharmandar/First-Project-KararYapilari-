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
    public partial class ÖDEV1 : Form
    {
        public ÖDEV1()
        {
            InitializeComponent();
        }

        //Formun ilk acilis aninda 8 haneli rastgele bir sayı lblRastgeleKarakterler 
        //adli label'a yazdirilacak ve kullanicidan butona bastigi anda textbox'taki 
        //yazıyla label'daki yazının karsilastirmasi yapilacak. Eger karsilastirma 
        //olumsuz ise lblKalanHakkimiz'deki deger bir azaltılacak. 
        //Eger kullanici 5 defa hatali giris yaparsa button'un aktiflik ozelligi kapatilacak...
        //Her hatali giriste yeni bir rastgele sayi turetilmelidir...

        private void Form2_Load(object sender, EventArgs e)
        {
            
            
            Random rnd = new Random();
            lblRastgele.Text = rnd.Next(10000000, 100000000).ToString();
            int sayi = rnd.Next();
                            
        }
              

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi = int.Parse(txtGiris.Text);

                if (sayi == lblRastgele.Text.Length)
                {
                    MessageBox.Show("şifre başarılı");
                }
                else
                {
                    
                    MessageBox.Show("başarısız giriş,tekrar deneyiniz");
                }

                Random rnd = new Random();
                lblRastgele.Text = rnd.Next(10000000, 100000000).ToString();

            }
            catch (FormatException hata)
            {
                MessageBox.Show("sayısal değer giriniz");
                MessageBox.Show(hata.Message);
            }
            catch (OverflowException hata)
            {
                MessageBox.Show("fazla değer girdiniz");
                MessageBox.Show(hata.Message);
            }
            catch (Exception)
            {
                
                throw;
            }
                    
                                     
                int Left = int.Parse(lblKalanHakkimiz.Text);
               

                if (Left > 0)
                {
                    Left = Left - 1;
                    lblKalanHakkimiz.Text = Left.ToString();

                }
                else
                {
                
                btnGirisYap.Enabled = true;
                MessageBox.Show("Sorry, Button is inactive, please try again 5 min later");
                
                }

            

            txtGiris.Clear();
            txtGiris.Focus();
        }

        

        private void lblKalanHakkimiz_Click(object sender, EventArgs e)
        {

        }

        private void txtGiris_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
