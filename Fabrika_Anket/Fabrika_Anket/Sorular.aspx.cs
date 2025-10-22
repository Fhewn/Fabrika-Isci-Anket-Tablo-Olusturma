using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Reflection.Emit;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Denim_Anket
{
    public partial class SoruGor : System.Web.UI.Page
    {
        dataBase db = new dataBase();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                lblCevap.Text = "";
                DataTable dtSoru = db.SoruListele();
                lblKullanici.Text = Session["AdSoyad"].ToString();
                lblSicilId.Text = Session["SicilId"].ToString();

                int sayi = 1;
                if (int.TryParse(lblSayi.Text, out sayi))
                {
                    lblSayi.Text = (sayi + 1).ToString();
                    lblSayi2.Text = lblSayi.Text;
                    DataTable dtSoruList = db.SoruGor(Convert.ToInt32(lblSayi.Text));
                    if (dtSoruList != null && dtSoruList.Rows.Count > 0)
                    {
                        lblSoruGetir.Text = dtSoruList.Rows[0]["Soru"].ToString();
                    }
                    else
                    {
                        lblSoruGetir.Text = "Listelenecek Başka Bir Soru Bulunamadı.";
                    }
                }
                else
                {
                    lblSayi.Text = "0";
                }
            }

        }

        private void SayiMetot()
        {
            throw new NotImplementedException();
        }


        public void SoruKayit(int sicilId, int SoruId, string secilenCevap)
        {
            int sicilid = sicilId;
            int soruid = SoruId;
            string SecilenCevap = secilenCevap;
            string departmanAdi = Session["DepartmanAdi"].ToString();
            db.SoruKayit(sicilId, soruid, secilenCevap, departmanAdi);
            lblCevap.Text = "";
            SqlConnection baglan = new SqlConnection("Data Source=LAPTOP-M7119PBB;Initial Catalog=Denim_Anket;Integrated Security=SSPI;Connect Timeout=420");
            SqlCommand com = new SqlCommand("Select * from Soru", baglan);
            int sayi = 0;
            if (int.TryParse(lblSayi.Text, out sayi))
            {
                lblSayi.Text = (sayi + 1).ToString();
                lblSayi2.Text = lblSayi.Text;
                DataTable dtSoruList = db.SoruGor(Convert.ToInt32(lblSayi.Text));
                if (dtSoruList != null && dtSoruList.Rows.Count > 0)
                {
                    lblSoruGetir.Text = dtSoruList.Rows[0]["Soru"].ToString();
                }
                else
                {
                    lblSoruGetir.Text = "Listelenecek Başka Bir Soru Bulunamadı.";
                }
            }
            else
            {
                lblSayi.Text = "0";
            }

            if (lblSayi2.Text == "69")
            {
               
            }
        }


        protected void lblSayi_TextChanged(object sender, EventArgs e)
        {

        }

        protected void imgBtn1_Click(object sender, ImageClickEventArgs e)
        {
            lblCevap.Text = imgBtn1.AlternateText;
            int sicilId = Convert.ToInt32(lblSicilId.Text);
            int soruId = Convert.ToInt32(lblSayi.Text);
            string secilenCevap = lblCevap.Text;
            SoruKayit(sicilId, soruId, secilenCevap);
        }

        protected void imgkatilmiyom_Click(object sender, ImageClickEventArgs e)
        {
            lblCevap.Text = imgkatilmiyom.AlternateText;
            int sicilId = Convert.ToInt32(lblSicilId.Text);
            int soruId = Convert.ToInt32(lblSayi.Text);
            string secilenCevap = lblCevap.Text;
            SoruKayit(sicilId, soruId, secilenCevap);
        }

        protected void imgkararsiz_Click(object sender, ImageClickEventArgs e)
        {
            lblCevap.Text = imgkararsiz.AlternateText;
            int sicilId = Convert.ToInt32(lblSicilId.Text);
            int soruId = Convert.ToInt32(lblSayi.Text);
            string secilenCevap = lblCevap.Text;
            SoruKayit(sicilId, soruId, secilenCevap);
        }

        protected void imgkatiliyom_Click(object sender, ImageClickEventArgs e)
        {
            lblCevap.Text = imgkatiliyom.AlternateText;
            int sicilId = Convert.ToInt32(lblSicilId.Text);
            int soruId = Convert.ToInt32(lblSayi.Text);
            string secilenCevap = lblCevap.Text;
            SoruKayit(sicilId, soruId, secilenCevap);
        }

        protected void imgkkatiliyom_Click(object sender, ImageClickEventArgs e)
        {
            lblCevap.Text = imgkkatiliyom.AlternateText;
            int sicilId = Convert.ToInt32(lblSicilId.Text);
            int soruId = Convert.ToInt32(lblSayi.Text);
            string secilenCevap = lblCevap.Text;
            SoruKayit(sicilId, soruId, secilenCevap);
        }
    }
}
