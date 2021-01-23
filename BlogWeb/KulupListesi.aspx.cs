using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class KulupListesi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLKULUPLERTableAdapter dt = new
                DataSet1TableAdapters.TBLKULUPLERTableAdapter();
            Repeater1.DataSource = dt.KuluplerListesi();
            Repeater1.DataBind();
        }
    }
}