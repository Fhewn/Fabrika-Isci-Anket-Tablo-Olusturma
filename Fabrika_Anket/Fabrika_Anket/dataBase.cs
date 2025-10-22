using Denim_Anket.Yonetim;
using Microsoft.Win32;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI.WebControls;

namespace Denim_Anket
{
    public class dataBase
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlConn"].ConnectionString);

        veritabani vt = new veritabani();


        public void SoruEkle(string Soru)
        {
            SqlCommand cmdSoruEkle = new SqlCommand("insert into Soru (Soru) Values (@Soru)", conn);
            cmdSoruEkle.Parameters.AddWithValue("@Soru", Soru);
            conn.Open();
            cmdSoruEkle.ExecuteNonQuery();
            conn.Close();

        }
        public DataTable SoruListele()
        {
            DataTable dtSoru = vt.DataTable("Select * from Soru");
            return dtSoru;
        }
        public void SoruSil(int soruId)
        {

            SqlCommand cmdSoruSil = new SqlCommand("Delete From Soru where Id=@Id", conn);
            conn.Open();
            cmdSoruSil.Parameters.AddWithValue("@Id", soruId);
            cmdSoruSil.ExecuteNonQuery();
            conn.Close();
        }
        public void SoruGuncel(string Soru, int SoruId)
        {
            SqlCommand cmdSoruGuncel = new SqlCommand("update Soru Set Soru=@Soru Where Id=" + SoruId + "", conn);
            conn.Open();
            cmdSoruGuncel.Parameters.AddWithValue("@Soru", Soru);
            cmdSoruGuncel.ExecuteNonQuery();
            conn.Close();
        }

        public DataTable SoruGor(int SoruId)
        {
            DataTable dtSorular = vt.DataTable("Select * from Soru Where Id=" + SoruId + "");
            return dtSorular;
        }

        public DataTable PersonelListesi()
        {
            DataTable dtPersonelListesi = vt.DataTable("Select * from Personel");
            return dtPersonelListesi;
        }

        public void SoruKayit(int SicilId, int SoruId, int SecimId)
        {
            SqlCommand cmdSoruKayit = new SqlCommand("insert into Secim (SicilId,SoruId,SecimId,Tarih) values (@SicilId,@SoruId,@SecimId,@Tarih)", conn);
            conn.Open();
            cmdSoruKayit.Parameters.AddWithValue("@SicilId", SicilId);
            cmdSoruKayit.Parameters.AddWithValue("@SoruId", SoruId);
            cmdSoruKayit.Parameters.AddWithValue("@SecimId", SecimId);
            cmdSoruKayit.Parameters.AddWithValue("@Tarih", DateTime.Now);
            cmdSoruKayit.ExecuteNonQuery();
            conn.Close();
        }
        //public void KullaniciGiris(int SiciIid, string AdSoyad, string Cinsiyet, string Yas, string Statunuz, string DepartmanAdi)
        //{
        //  SqlCommand cmdGiris = new SqlCommand("insert into Kisi (SiciIid,AdSoyad,Cinsiyet,Yas,Statunuz,DepartmanAdi,Ay,Yil) Values (@SiciIid,@AdSoyad,@Cinsiyet,@Yas,@Statunuz,@DepartmanAdi,@Ay,@Yil)", conn);
        //conn.Open();
        //cmdGiris.Parameters.AddWithValue("@SiciIid", SiciIid);
        //cmdGiris.Parameters.AddWithValue("@AdSoyad", AdSoyad);
        //cmdGiris.Parameters.AddWithValue("@Cinsiyet", Cinsiyet);
        //cmdGiris.Parameters.AddWithValue("@Yas", Yas);
        //cmdGiris.Parameters.AddWithValue("@Statunuz", Statunuz);
        //cmdGiris.Parameters.AddWithValue("@DepartmanAdi", DepartmanAdi);
        //cmdGiris.Parameters.AddWithValue("@Ay", DateTime.Now.Month);
        //cmdGiris.Parameters.AddWithValue("@Yil", DateTime.Now.Year);
        //cmdGiris.ExecuteNonQuery();
        //conn.Close();
        // }
        public void KullaniciGiris(int SiciIid, string AdSoyad, string DepartmanAdi)
        {
            SqlCommand cmdGiris = new SqlCommand("insert into Kisi (SiciIid,AdSoyad,DepartmanAdi,Ay,Yil) Values (@SiciIid,@AdSoyad,@Cinsiyet,@Yas,@Statunuz,@DepartmanAdi,@Ay,@Yil)", conn);
            conn.Open();
            cmdGiris.Parameters.AddWithValue("@SiciIid", SiciIid);
            cmdGiris.Parameters.AddWithValue("@AdSoyad", AdSoyad);
            cmdGiris.Parameters.AddWithValue("@DepartmanAdi", DepartmanAdi);
            cmdGiris.Parameters.AddWithValue("@Ay", DateTime.Now.Month);
            cmdGiris.Parameters.AddWithValue("@Yil", DateTime.Now.Year);
            cmdGiris.ExecuteNonQuery();
            conn.Close();
        }

      
        public DataTable SoruSecilen()
        {
            DataTable dtSecim = vt.DataTable("Select * from Secim");
            return dtSecim;
        }

        public void SoruKayit(int sicilId, int soruId, string SecimNo, string departmanAdi)
        {
            SqlCommand cmdKayit = new SqlCommand("insert Into Secim (Sicilid,SoruId,Cevap,Tarih,Ay,Yil,DepartmanAdi) Values (@Sicilid,@SoruId,@Cevap,@Tarih,@Ay,@Yil,@DepartmanAdi)", conn);
            cmdKayit.Parameters.AddWithValue("@Sicilid", sicilId);
            cmdKayit.Parameters.AddWithValue("@SoruId", soruId);
            cmdKayit.Parameters.AddWithValue("@Cevap", SecimNo);
            cmdKayit.Parameters.AddWithValue("@Tarih", DateTime.Now);
            cmdKayit.Parameters.AddWithValue("@Ay", DateTime.Now.Month);
            cmdKayit.Parameters.AddWithValue("@Yil", DateTime.Now.Year);
            cmdKayit.Parameters.AddWithValue("@DepartmanAdi", departmanAdi);
            conn.Open();
            cmdKayit.ExecuteNonQuery();
            conn.Close();

        }

    // public DataTable DepartmanBilgisi()
    // {
    //   DataTable dtDepartman = vt.DataTable("select * from Personel where AdSoyad is not null and AdSoyad <> '' and SpecialCode = 'IK' order by AdSoyad asc");
    // return dtDepartman;
    //}
   
}
}
