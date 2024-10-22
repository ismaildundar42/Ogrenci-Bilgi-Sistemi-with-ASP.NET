﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class Grafikler : System.Web.UI.Page
{
    SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-6M1J8AO\\SQLEXPRESS;Initial Catalog=DbUdemyOgrenci;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        // Chart 4 donate kod
        baglanti.Open();
        SqlCommand komut = new SqlCommand("Execute Graf1",baglanti);
        SqlDataReader dr = komut.ExecuteReader();
        while(dr.Read())
        {
            Chart4.Series["Dersler"].Points.AddXY(dr[0], int.Parse(dr[1].ToString()));
        }
        baglanti.Close();
        // Chart 3 pasta kodu
        baglanti.Open();
        SqlCommand komut2 = new SqlCommand("Execute Graf2", baglanti);
        SqlDataReader dr2 = komut2.ExecuteReader();
        while (dr2.Read())
        {
            Chart3.Series["Cinsiyet"].Points.AddXY(dr2[0], int.Parse(dr2[1].ToString()));
        }
        baglanti.Close();

        // Chart 2 kodu
        baglanti.Open();
        SqlCommand komut3 = new SqlCommand("Execute Graf3", baglanti);
        SqlDataReader dr3 = komut3.ExecuteReader();
        while(dr3.Read())
        {
            Chart2.Series["DersAd"].Points.AddXY(dr3[0], int.Parse(dr3[1].ToString()));
        }
        baglanti.Close();

        // Chart 1 kodu
        baglanti.Open();
        SqlCommand komut4 = new SqlCommand("Execute Graf4", baglanti);
        SqlDataReader dr4 = komut4.ExecuteReader();
        while(dr4.Read())
        {
            Chart1.Series["Notlar"].Points.AddXY(dr4[0], int.Parse(dr4[1].ToString()));
        }
        baglanti.Close();
    }
}