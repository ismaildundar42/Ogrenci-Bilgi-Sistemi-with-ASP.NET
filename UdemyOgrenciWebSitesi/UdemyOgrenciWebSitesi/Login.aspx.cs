using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class Login : System.Web.UI.Page
{

    SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-6M1J8AO\SQLEXPRESS;Initial Catalog=DbUdemyOgrenci;Integrated Security=True;");

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        baglanti.Open();
        SqlCommand komut = new SqlCommand("select * from tbl_ogrenciler where numara=@p1 and ogrsıfre=@p2", baglanti);
        komut.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
        komut.Parameters.AddWithValue("@p2", txtSifre.Text);
        SqlDataReader dr = komut.ExecuteReader();
        if (dr.Read())
        {
            Response.Redirect("OgrenciDefault.aspx?NUMARA="+txtKullaniciAdi.Text);
        }
        else
        {
            txtSifre.Text = "Hatalı Şifre";
        }
        baglanti.Close();
    }
}

