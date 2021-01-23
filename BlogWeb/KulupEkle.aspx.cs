using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class KulupEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLKULUPLERTableAdapter dt = new
                DataSet1TableAdapters.TBLKULUPLERTableAdapter();
            dt.KulupEkle(TextBox1.Text);
            Response.Redirect("KulupListesi.Aspx");
        }
    }
}