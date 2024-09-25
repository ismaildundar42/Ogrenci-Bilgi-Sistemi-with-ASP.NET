using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DuyuruGuncelle : System.Web.UI.Page
{
    int id;
    protected void Page_Load(object sender, EventArgs e)
    {
        id = Convert.ToInt32(Request.QueryString["DUYURUID"]);
        if (Page.IsPostBack==false)
        {
            DataSetTableAdapters.tbl_duyurularTableAdapter dt = new DataSetTableAdapters.tbl_duyurularTableAdapter();
            TxtDuyuruId.Text = id.ToString();
            txtDuyuruBaslik.Text = dt.DuyuruSec(id)[0].DUYURUBASLIK;
            TextArea1.Value = dt.DuyuruSec(id)[0].DUYURUICERIK;

        }
    }

    protected void btnDuyuruGuncelle_Click(object sender, EventArgs e)
    {
        DataSetTableAdapters.tbl_duyurularTableAdapter dt = new DataSetTableAdapters.tbl_duyurularTableAdapter();
        dt.DuyuruGuncelle(txtDuyuruBaslik.Text, TextArea1.Value, Convert.ToInt32(TxtDuyuruId.Text));
        Response.Redirect("DuyuruListesi.aspx");
    }
}