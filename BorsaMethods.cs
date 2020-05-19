using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDeneme
{
   
    public class BorsaMethods
    {
        const double ziraat_komisyon = 0.0015;
        const double garanti_komisyon = 0.0018;
        public static double ZiraatAlisToplamKomisyon(double alis_birim_fiyat, double lot_sayisi)
        {
            double total_para = alis_birim_fiyat * lot_sayisi;
            double alis_total_komisyon = total_para * ziraat_komisyon;
            return Convert.ToDouble(String.Format("{0:0.000}", alis_total_komisyon));
        }
        public static double GarantiAlisToplamKomisyon(double alis_birim_fiyat, double lot_sayisi)
        {
            double total_para = alis_birim_fiyat * lot_sayisi;
            double alis_total_komisyon = total_para * garanti_komisyon;
            return Convert.ToDouble(String.Format("{0:0.000}", alis_total_komisyon));
        }
        public static double SatisToplamKomisyon(double satis_birim_fiyat, double lot_sayisi)
        {
            double total_para = satis_birim_fiyat * lot_sayisi;
            double satis_total_komisyon = total_para * ziraat_komisyon;
            return Convert.ToDouble(String.Format("{0:0.000}", satis_total_komisyon));
        }
        public static double AldiktanSonrakiFiyat(double alis_birim_fiyat, double lot_sayisi)
        {
            double total_para = alis_birim_fiyat * lot_sayisi;
            return Convert.ToDouble(String.Format("{0:0.000}", total_para));
        }
        public static double SattiktanSonrakiFiyat(double satis_birim_fiyat, double lot_sayisi)
        {
            double total_para = satis_birim_fiyat * lot_sayisi;
            return Convert.ToDouble(String.Format("{0:0.000}", total_para));
        }
        public static double AlisSatisFarki(double alis_birim_fiyat, double satis_birim_fiyat, double lot_sayisi)
        {
            double alis = AldiktanSonrakiFiyat(alis_birim_fiyat, lot_sayisi);
            double satis = SattiktanSonrakiFiyat(satis_birim_fiyat, lot_sayisi);
            double sonuc = satis - alis - ZiraatAlisToplamKomisyon(alis_birim_fiyat, lot_sayisi) - SatisToplamKomisyon(satis_birim_fiyat, lot_sayisi);
            return Convert.ToDouble(String.Format("{0:0.000}", sonuc));
        }
        public static double YuzdeKarZarar(double alis_birim_fiyat, double satis_birim_fiyat, double lot_sayisi)
        {
            double sonuc = AlisSatisFarki(alis_birim_fiyat, satis_birim_fiyat, lot_sayisi);
            double yuzde_farki = (sonuc / AldiktanSonrakiFiyat(alis_birim_fiyat, lot_sayisi)) * 100;
            return Convert.ToDouble(String.Format("{0:0.00}", yuzde_farki));
        }
        public static double ZiraatMinimumSatisFiyati(double alis_birim_fiyat, double lot_sayisi)
        {
            double alis = AldiktanSonrakiFiyat(alis_birim_fiyat, lot_sayisi) + ZiraatAlisToplamKomisyon(alis_birim_fiyat, lot_sayisi);
            double minimum_satis = (alis * 10000) / 9985;
            return Convert.ToDouble(String.Format("{0:0.0000}", minimum_satis));
        }
        public static double ZiraatMinimumBirimSatisFiyati(double alis_birim_fiyat)
        {
            double alis = alis_birim_fiyat + ziraat_komisyon * alis_birim_fiyat;
            double minimum_satis = (alis * 10000) / (10000 - (ziraat_komisyon * 10000));
            return Convert.ToDouble(String.Format("{0:0.000}", minimum_satis));
        }
        public static double GarantiMinimumSatisFiyati(double alis_birim_fiyat, double lot_sayisi)
        {
            double alis = AldiktanSonrakiFiyat(alis_birim_fiyat, lot_sayisi) + GarantiAlisToplamKomisyon(alis_birim_fiyat, lot_sayisi);
            double minimum_satis = (alis * 10000) / 9985;
            return Convert.ToDouble(String.Format("{0:0.0000}", minimum_satis));
        }
        public static double GarantiMinimumBirimSatisFiyati(double alis_birim_fiyat)
        {
            double alis = alis_birim_fiyat + garanti_komisyon * alis_birim_fiyat;
            double minimum_satis = (alis * 10000) / (10000 - (garanti_komisyon * 10000));
            return Convert.ToDouble(String.Format("{0:0.000}", minimum_satis));
        }
        public static double ZiraatIstenenYuzdeyeGoreBirimSatisFiyati(double alis_birim_fiyat, double yuzde)
        {
            double artis = (yuzde / 100) * alis_birim_fiyat;
            double alis = alis_birim_fiyat;
            double satis = (alis + artis + ziraat_komisyon * alis) / (1 - ziraat_komisyon);
            return Convert.ToDouble(String.Format("{0:0.000}", satis));
        }
        public static double GarantiIstenenYuzdeyeGoreBirimSatisFiyati(double alis_birim_fiyat, double yuzde)
        {
            double artis = (yuzde / 100) * alis_birim_fiyat;
            double alis = alis_birim_fiyat;
            double satis = (alis + artis + garanti_komisyon * alis) / (1 - garanti_komisyon);
            return Convert.ToDouble(String.Format("{0:0.000}", satis));
        }
        public static double IstenenYuzdeyeGoreSatisFiyati(double alis_birim_fiyat, double lot_sayisi, double yuzde)
        {
            double artis = (yuzde / 100) * AldiktanSonrakiFiyat(alis_birim_fiyat, lot_sayisi);
            double alis = AldiktanSonrakiFiyat(alis_birim_fiyat, lot_sayisi);
            double satis = alis + artis + ZiraatAlisToplamKomisyon(alis_birim_fiyat, lot_sayisi);
            double satis_komisyon = satis * ziraat_komisyon;
            double sonuc_satis = satis_komisyon + satis;
            return Convert.ToDouble(String.Format("{0:0.000}", sonuc_satis));
        }
    }
}
