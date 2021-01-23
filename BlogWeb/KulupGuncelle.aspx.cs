using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class KulupGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int s = Convert.ToInt16(Request.QueryString["ID"]);
            Txtid.Text = s.ToString();
            Txtid.Enabled = false;

            if(Page.IsPostBack == false)
            {
                DataSet1TableAdapters.TBLKULUPLERTableAdapter dt = new
                    DataSet1TableAdapters.TBLKULUPLERTableAdapter();
                TxtKulup.Text = dt.KulupGetir(Convert.ToInt16(s))[0].KULUP;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLKULUPLERTableAdapter dt = new
                DataSet1TableAdapters.TBLKULUPLERTableAdapter();
            dt.KulupGuncelle(TxtKulup.Text, Convert.ToInt16(Txtid.Text));
            Response.Redirect("KulupListesi.Aspx");
        }
    }
}