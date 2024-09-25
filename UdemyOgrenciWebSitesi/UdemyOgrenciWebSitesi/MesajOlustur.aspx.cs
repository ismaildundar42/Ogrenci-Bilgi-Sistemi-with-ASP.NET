using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MesajOlustur : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        txtGonderen.Text = "0001";
    }

    protected void btnMesajGonder_Click(object sender, EventArgs e)
    {
        DataSetTableAdapters.tbl_mesajlarTableAdapter dt = new DataSetTableAdapters.tbl_mesajlarTableAdapter();
       dt.MesajGonder(txtGonderen.Text,txtAlici.Text,txtMesajBaslik.Text,txtMesajIcerik.Value);
        Response.Redirect("GidenMesajlar.aspx");
    }
}