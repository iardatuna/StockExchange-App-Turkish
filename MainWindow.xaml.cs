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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AppDeneme
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

     
        public class DGWYuzdeSatis
        {
            public double Yuzde { get; set; }
            public double SatisBirimFiyat { get; set; }
        }

        private void TextBoxSatisBirimFiyati_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBoxIstenilenYuzde_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBoxLotSayisi_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {

            double alis_birim_fiyat = Convert.ToDouble(TextBoxAlisBirimFiyati.Text);
            double yuzde = Convert.ToDouble(TextBoxIstenilenYuzde.Text);
            double satis_birim_fiyat = Convert.ToDouble(TextBoxSatisBirimFiyati.Text);
            double lot_sayisi = Convert.ToDouble(TextBoxLotSayisi.Text);
            string kagit_adi = TextBoxKagitAdi.Text;
            DGWYuzdeSatis yuzde1 = new DGWYuzdeSatis();
            DGWYuzdeSatis yuzde2 = new DGWYuzdeSatis();
            DGWYuzdeSatis yuzde3 = new DGWYuzdeSatis();
            DGWYuzdeSatis yuzde4 = new DGWYuzdeSatis();
            DGWYuzdeSatis yuzde5 = new DGWYuzdeSatis();
            DGWYuzdeSatis yuzde6 = new DGWYuzdeSatis();
            DGWYuzdeSatis yuzde7 = new DGWYuzdeSatis();
            DGWYuzdeSatis yuzde8 = new DGWYuzdeSatis();
            DGWYuzdeSatis yuzde9 = new DGWYuzdeSatis();
            DGWYuzdeSatis yuzde9_94 = new DGWYuzdeSatis();
            yuzde1.Yuzde = 1;
            yuzde1.SatisBirimFiyat = BorsaMethods.ZiraatIstenenYuzdeyeGoreBirimSatisFiyati(alis_birim_fiyat, 1);
            yuzde2.Yuzde = 2;
            yuzde2.SatisBirimFiyat = BorsaMethods.ZiraatIstenenYuzdeyeGoreBirimSatisFiyati(alis_birim_fiyat, 2);
            yuzde3.Yuzde = 3;
            yuzde3.SatisBirimFiyat = BorsaMethods.ZiraatIstenenYuzdeyeGoreBirimSatisFiyati(alis_birim_fiyat, 3);
            yuzde4.Yuzde = 4;
            yuzde4.SatisBirimFiyat = BorsaMethods.ZiraatIstenenYuzdeyeGoreBirimSatisFiyati(alis_birim_fiyat, 4);
            yuzde5.Yuzde = 5;
            yuzde5.SatisBirimFiyat = BorsaMethods.ZiraatIstenenYuzdeyeGoreBirimSatisFiyati(alis_birim_fiyat, 5);
            yuzde6.Yuzde = 6;
            yuzde6.SatisBirimFiyat = BorsaMethods.ZiraatIstenenYuzdeyeGoreBirimSatisFiyati(alis_birim_fiyat, 6);
            yuzde7.Yuzde = 7;
            yuzde7.SatisBirimFiyat = BorsaMethods.ZiraatIstenenYuzdeyeGoreBirimSatisFiyati(alis_birim_fiyat, 7);
            yuzde8.Yuzde = 8;
            yuzde8.SatisBirimFiyat = BorsaMethods.ZiraatIstenenYuzdeyeGoreBirimSatisFiyati(alis_birim_fiyat, 8);
            yuzde9.Yuzde = 9;
            yuzde9.SatisBirimFiyat = BorsaMethods.ZiraatIstenenYuzdeyeGoreBirimSatisFiyati(alis_birim_fiyat, 9);
            yuzde9_94.Yuzde = 9.94;
            yuzde9_94.SatisBirimFiyat = BorsaMethods.ZiraatIstenenYuzdeyeGoreBirimSatisFiyati(alis_birim_fiyat, 9.94);
            if (DGWYuzdeSatisBirim.Items.Count != 0)
            {
                DGWYuzdeSatisBirim.ItemsSource = null;
                DGWYuzdeSatisBirim.Items.Clear();
            }
            DGWYuzdeSatisBirim.Items.Add(yuzde1);
            DGWYuzdeSatisBirim.Items.Add(yuzde2);
            DGWYuzdeSatisBirim.Items.Add(yuzde3);
            DGWYuzdeSatisBirim.Items.Add(yuzde4);
            DGWYuzdeSatisBirim.Items.Add(yuzde5);
            DGWYuzdeSatisBirim.Items.Add(yuzde6);
            DGWYuzdeSatisBirim.Items.Add(yuzde7);
            DGWYuzdeSatisBirim.Items.Add(yuzde8);
            DGWYuzdeSatisBirim.Items.Add(yuzde9);
            DGWYuzdeSatisBirim.Items.Add(yuzde9_94);
            Console.WriteLine(DGWYuzdeSatisBirim.Items.Count);
            TextBoxMinSatisZiraat.Text = Convert.ToString(BorsaMethods.ZiraatMinimumBirimSatisFiyati(alis_birim_fiyat));
            TextBoxMinSatisGaranti.Text = Convert.ToString(BorsaMethods.GarantiMinimumBirimSatisFiyati(alis_birim_fiyat));
            TextBoxToplamKarZarar.Text = Convert.ToString(BorsaMethods.AlisSatisFarki(alis_birim_fiyat, satis_birim_fiyat, lot_sayisi));
            TextBoxYuzdeselKarZarar.Text = Convert.ToString(BorsaMethods.YuzdeKarZarar(alis_birim_fiyat, satis_birim_fiyat, lot_sayisi));
            TextBoxIstenenYuzdeIcinSatisFiyatiGaranti.Text = Convert.ToString(BorsaMethods.GarantiIstenenYuzdeyeGoreBirimSatisFiyati(alis_birim_fiyat, yuzde));
            TextBoxIstenenYuzdeIcinSatisFiyatiZiraat.Text = Convert.ToString(BorsaMethods.ZiraatIstenenYuzdeyeGoreBirimSatisFiyati(alis_birim_fiyat, yuzde));
        }

        private void TextBoxAlisBirimFiyati_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void TextBoxKagitAdi_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void DGWYuzdeSatisBirim_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
