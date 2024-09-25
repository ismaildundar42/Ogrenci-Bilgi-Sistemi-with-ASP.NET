using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OgrenciEkle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Unnamed7_Click(object sender, EventArgs e)
    {
        DataSetTableAdapters.tbl_ogrencilerTableAdapter dt = new DataSetTableAdapters.tbl_ogrencilerTableAdapter();
        dt.OgrenciEkle(txtOgrAd.Text, txtOgrSoyad.Text, txtOgrTelefon.Text, txtOgrMail.Text, txtOgrSifre.Text, txtOgrFoto.Text);
        Response.Redirect("default.aspx"); // dataset işleminden sonra yönlendirme için kullanılır
    }
}