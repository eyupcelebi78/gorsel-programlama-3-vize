using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FirstProject
{
    /// <summary>
    /// Edit.xaml etkileşim mantığı
    /// </summary>
    public partial class Edit : Window
    {
        List<Bilgiler> bilgiler = new List<Bilgiler>();
        public Edit()
        {
            InitializeComponent();
            lblErrorMessage.Visibility = Visibility.Hidden;


        }

        public void errorMessage (string isim)
        {
            lblErrorMessage.Visibility = Visibility.Visible;
            lblErrorMessage.Content = isim+" Alanı boş bırakılamaz";
        }

        int syc = 0;
        private void btnKaydet_Click(object sender, RoutedEventArgs e)
        {
            if (txtAd.Text == "")
            {
                MessageBox.Show("İsim alanı boş geçilemez…");
                errorMessage("İsim");

            }

            else if (txtSoyad.Text == "")
            {
                MessageBox.Show("Soyisim alanı boş geçilemez…");
                errorMessage("Soyisim");
            }

            else if (cmbCinsiyet.Text == "")
            {
                MessageBox.Show("Cinsiyet alanı boş geçilemez…");
                errorMessage("Cinsiyet");
            }

            else if (txtOgrenciNo.Text == "")
            {
                MessageBox.Show("Öğrenci No alanı boş geçilemez…");
                errorMessage("Öğrenci No");
            }

            else if (cmbBolum.Text == "")
            {
                MessageBox.Show("Bölüm bilgisi boş geçilemez…");
                errorMessage("Bölüm");
            }

            else
            {

                
                Bilgiler kullanici = new Bilgiler();
                kullanici.Ad = txtAd.Text;
                kullanici.Soyad = txtSoyad.Text;
                kullanici.Cinsiyet = cmbCinsiyet.Text;
                kullanici.OgrenciNo = txtOgrenciNo.Text;
                kullanici.Bolum = cmbBolum.Text;
                bilgiler.Add(kullanici);
                tablo2.Items.Add(kullanici);
                cmbIndex.Items.Add(kullanici.Ad);
                lblErrorMessage.Visibility = Visibility.Hidden;
            }

        }

        private void cmbIndex_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var secilen = cmbIndex.SelectedIndex;
            MessageBox.Show("Ad : "+bilgiler[secilen].Ad + "\tSoyad : " + bilgiler[secilen].Soyad + "\tCinsiyet : " + bilgiler[secilen].Cinsiyet + "\tOgrenciNo : " + bilgiler[secilen].OgrenciNo + "\tBolum : " + bilgiler[secilen].Bolum);
        }
    }
}
    
