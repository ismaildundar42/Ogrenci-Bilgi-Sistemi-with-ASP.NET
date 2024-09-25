using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DersGuncelleme : System.Web.UI.Page
{
    int id;
    protected void Page_Load(object sender, EventArgs e)
    {
        id = Convert.ToInt32(Request.QueryString["DERSID"]);
        if (Page.IsPostBack==false)
        { 
            DataSetTableAdapters.tbl_derslerTableAdapter dt = new DataSetTableAdapters.tbl_derslerTableAdapter();
            txtDersID.Text = id.ToString();
            txtDersAd.Text = dt.DersGetir(id)[0].DERSAD.ToString();

        }
    }

    protected void btnDersGuncelle_Click(object sender, EventArgs e)
    {
        DataSetTableAdapters.tbl_derslerTableAdapter dt = new DataSetTableAdapters.tbl_derslerTableAdapter();
        dt.DersGuncelle(txtDersAd.Text, id);
        Response.Redirect("DersListesi.aspx");
    }
}