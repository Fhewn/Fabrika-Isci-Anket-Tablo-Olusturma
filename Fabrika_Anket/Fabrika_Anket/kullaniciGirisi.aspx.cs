using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;


namespace Denim_Anket
{

    public partial class kullaniciGirisi : System.Web.UI.Page
    {
        dataBase db = new dataBase();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                
                PersonelListesi();
            }
        }
        private void PersonelListesi()
        {
            DataTable dtPersonelListesi = db.PersonelListesi();
            if (dtPersonelListesi != null && dtPersonelListesi.Rows.Count > 0)
            {
                drpAdsoy.DataSource = dtPersonelListesi;
                drpAdsoy.DataTextField = "AdSoyad";
                drpAdsoy.DataValueField = "RecId";
                drpAdsoy.DataBind();
                drpAdsoy.Items.Insert(0, new ListItem("Ad-Soyad Seçiniz...", String.Empty));
            }

        }

        protected void btnKayit_Click(object sender, EventArgs e)
        {
            string AdSoyad = drpAdsoy.Text;
            string DepartmanAdi = "Yok";
            int SicilId = 0;
            Session.Add("DepartmanAdi", DepartmanAdi);
            Session.Add("AdSoyad", AdSoyad);
            Session.Add("SicilId", SicilId);
            db.Ku(SicilId, AdSoyad, DepartmanAdi);
            Server.Transfer("Sorular.aspx");          
        }
        protected void btnMisafir_Click(object sender, EventArgs e)
        {
            string AdSoyad ="Denim Kumaþ Fabrika";
            string departmanAdi = "YOK";
            int SicilId = 0;
            db.KullaniciGiris(SicilId, AdSoyad, departmanAdi);
            Session.Add("AdSoyad", AdSoyad);
            Session.Add("SiciIid", SicilId);
            Session.Add("DepartmanAdi", departmanAdi);
            Server.Transfer("Sorular.aspx");
        }

        protected void txtSoyAd_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnDepartmanAdi_Click(object sender, EventArgs e)
        {
            string AdSoyad = "Denim Kumaþ Fabrika";
            string Cinsiyet = "Yok";
            string Yas = "Yok";
            string Statunuz = "Yok";
            string departmanAdi = drpDepartman.SelectedItem.Text;
            int SicilId = 0;
            db.KullaniciGiris(SicilId, AdSoyad, Cinsiyet, Yas, Statunuz, departmanAdi);
            Session.Add("AdSoyad", AdSoyad);
            Session.Add("SiciIid", SicilId);
            Session.Add("DepartmanAdi", departmanAdi);
            Server.Transfer("Sorular.aspx");
        }

    }

   
}
