using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Configuration;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DuyuruEkle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       if(Page.IsPostBack==false)
        {
            DataSetTableAdapters.tbl_ogretmenlerTableAdapter dt = new DataSetTableAdapters.tbl_ogretmenlerTableAdapter();
            DropDownList1.DataSource = dt.OgretmenListesi();
            DropDownList1.DataTextField = "OGRTADSOYAD";   // display member'a benziyor 
            DropDownList1.DataValueField = "OGRTID";       // value member
            DropDownList1.DataBind();
        }
    }

    protected void btnDuyuruOlustur_Click(object sender, EventArgs e)
    {
        DataSetTableAdapters.tbl_duyurularTableAdapter dt = new DataSetTableAdapters.tbl_duyurularTableAdapter();
        dt.DuyuruEkle(txtDuyuruBaslik.Text, TextArea1.Value.ToString(),int.Parse(DropDownList1.SelectedValue));
        Response.Redirect("DuyuruListesi.aspx");
    }
}