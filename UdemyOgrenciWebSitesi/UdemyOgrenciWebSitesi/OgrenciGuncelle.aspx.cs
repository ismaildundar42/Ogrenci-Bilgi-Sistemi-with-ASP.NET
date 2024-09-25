using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OgrenciGuncelle : System.Web.UI.Page
{
    int id;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            try
            {
                id = Convert.ToInt32(Request.QueryString["OGRID"].ToString());
                txtOgrId.Text = id.ToString();
                DataSetTableAdapters.tbl_ogrencilerTableAdapter dt = new DataSetTableAdapters.tbl_ogrencilerTableAdapter();
                txtOgrAd.Text = dt.OgrenciSec(id)[0].OGRAD;
                txtOgrSoyad.Text = dt.OgrenciSec(id)[0].OGRSOYAD;
                txtOgrTelefon.Text = dt.OgrenciSec(id)[0].OGRTELEFON;
                txtOgrMail.Text = dt.OgrenciSec(id)[0].OGRMAIL;
                txtOgrSifre.Text = dt.OgrenciSec(id)[0].OGRSIFRE;
                txtOgrFoto.Text = dt.OgrenciSec(id)[0].OGRFOTOGRAF;
            }
            catch (Exception)
            {

                txtOgrFoto.Text = "!! Link Giriniz !!";
            }
        }

    }
    protected void btnOgrenciGuncelle_Click(object sender, EventArgs e)
    {
        DataSetTableAdapters.tbl_ogrencilerTableAdapter dt = new DataSetTableAdapters.tbl_ogrencilerTableAdapter();
        dt.OgrenciGuncelle(txtOgrAd.Text, txtOgrSoyad.Text, txtOgrFoto.Text, txtOgrTelefon.Text, txtOgrMail.Text, txtOgrSifre.Text, int.Parse(txtOgrId.Text));
        Response.Redirect("Default.aspx"); // istenilen sayfaya yönlendirmesi için komut
      
    }
}