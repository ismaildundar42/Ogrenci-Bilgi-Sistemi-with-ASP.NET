using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DersSilme : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int id = Convert.ToInt32(Request.QueryString["DERSID"].ToString());
        DataSetTableAdapters.tbl_derslerTableAdapter dt = new DataSetTableAdapters.tbl_derslerTableAdapter();
        dt.DersSilme(id);
        Response.Redirect("DersListesi.aspx");

    }
}