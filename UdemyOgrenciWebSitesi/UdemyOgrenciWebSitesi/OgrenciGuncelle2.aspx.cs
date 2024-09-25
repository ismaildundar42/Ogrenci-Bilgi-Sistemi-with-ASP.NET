using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OgrenciGuncelle2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Page.IsPostBack == false)
        {
            textbox1.Text = Request.QueryString["NUMARA"];
        }
    }

    protected void btnDuyuruGuncelle_Click(object sender, EventArgs e)
    {
        DataSetTableAdapters.tbl_ogrencilerTableAdapter dt = new DataSetTableAdapters.tbl_ogrencilerTableAdapter();
        
        dt.OgrenciSifreGuncelle(txtSifre1.Text, textbox1.Text);
        Response.Redirect("OgrenciDefault.aspx?NUMARA="+textbox1.Text);
    }
}