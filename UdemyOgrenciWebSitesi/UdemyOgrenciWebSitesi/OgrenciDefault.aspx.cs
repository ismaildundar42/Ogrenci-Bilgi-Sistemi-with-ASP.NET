using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OgrenciDefault : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        textbox1.Text =Request.QueryString["NUMARA"];

        DataSetTableAdapters.tbl_ogrencilerTableAdapter dt = new DataSetTableAdapters.tbl_ogrencilerTableAdapter();
        textbox2.Text = "AD SOYAD : "+dt.OgrenciPaneliGetir(textbox1.Text)[0].OGRAD + " "+dt.OgrenciPaneliGetir(textbox1.Text)[0].OGRSOYAD;
        textbox3.Text = "MAİL : "+dt.OgrenciPaneliGetir(textbox1.Text)[0].OGRMAIL;
        textbox5.Text ="TELEFON : "+ dt.OgrenciPaneliGetir(textbox1.Text)[0].OGRTELEFON;
        textbox6.Text = "SİFRE : "+dt.OgrenciPaneliGetir(textbox1.Text)[0].OGRSIFRE;
        // textbox6.Text = dt.OgrenciPaneliGetir(textbox1.Text)[0].OGRCINSIYET;
        textbox7.Text = "NULL";
        textbox4.Text = "NULL";

    }

    protected void btnDuyuruGuncelle_Click(object sender, EventArgs e)
    {
        Response.Redirect("OgrenciGuncelle2.aspx?NUMARA=" + textbox1.Text);
    }
}