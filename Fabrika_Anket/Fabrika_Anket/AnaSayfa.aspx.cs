using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Denim_Anket
{
  public partial class AnaSayfa : System.Web.UI.Page
  {
    dataBase db = new dataBase();
    protected void Page_Load(object sender, EventArgs e)
    {
      if (!Page.IsPostBack)
      {
        SorularıGetir();
      }
    }

    private void SorularıGetir()
    {
      DataTable dtsoru = db.soruGetir();
      if (dtsoru!=null && dtsoru.Rows.Count>0)
      {
        dataSoru.DataSource = dtsoru;
        dataSoru.DataBind();
      }
    }
  }
}
