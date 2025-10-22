using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Denim_Anket.Yonetim
{
  public partial class SoruIslemleri : System.Web.UI.Page
  {

    dataBase db = new dataBase();
    protected void Page_Load(object sender, EventArgs e)
    {
      if (!Page.IsPostBack)
      {
        SoruListele();
      }
    }
    private void SoruListele()
    {
      //Soru Tablo Gösterme

      DataTable dtSoru = db.SoruListele();
      drpSoruListesi.DataSource = dtSoru;
      drpSoruListesi.DataBind();

      //Soru Tablo Güncelleme Kısım

      dtSoruList.DataSource = dtSoru;
      dtSoruList.DataBind();

      // Soru Silme Kısım

      DataTable dlSoruList = db.SoruListele();
      drpSoruListesi.DataSource = dlSoruList;
      drpSoruListesi.DataTextField = "Soru";
      drpSoruListesi.DataValueField = "Id";
      drpSoruListesi.DataBind();


      ///Soru Guncelle Kısım

      DataTable dlSoruGüncel = db.SoruListele();
      drpSoruListesi.DataSource = dlSoruGüncel;
      drpSoruListesi.DataTextField = "Soru";
      drpSoruListesi.DataValueField = "Id";
      drpSoruListesi.DataBind();

      drpSoruGuncelle.DataSource = dlSoruGüncel;
      drpSoruGuncelle.DataTextField = "Soru";
      drpSoruGuncelle.DataValueField = "Id";
      drpSoruGuncelle.DataBind();
    }

    protected void btnSoruKayit_Click(object sender, EventArgs e)
    {
      string soru = txtSoru.Text;
      db.SoruEkle(soru);
      txtSoru.Text = "";
      System.Threading.Thread.Sleep(2000);
      SoruListele();
    }

    protected void btnSoruSil_Click(object sender, EventArgs e)
    {
      int soruId = Convert.ToInt32(Label1.Text);
      db.SoruSil(soruId);
      SoruListele();
      System.Threading.Thread.Sleep(2000);
      Label1.Text = "";
    }
    protected void drpSoruListesi_SelectedIndexChanged(object sender, EventArgs e)
    {
      Label1.Text = drpSoruListesi.SelectedValue.ToString();
    }

    protected void btnSoruGuncel_Click(object sender, EventArgs e)
    {
      string Soru = txtSoruGuncelle.Text;
      db.SoruGuncel(Soru, Convert.ToInt32(drpSoruGuncelle.Text));
      SoruListele();

    }
  }

}


