using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class NotGuncelle : System.Web.UI.Page
{
    int notID;
    protected void Page_Load(object sender, EventArgs e)
    {
        notID = Convert.ToInt32(Request.QueryString["NOTID"].ToString());

        DataSetTableAdapters.OgrNotlarTableAdapter dt = new DataSetTableAdapters.OgrNotlarTableAdapter();

        if (Page.IsPostBack == false)
        {
            txtOgrenciID.Text = dt.NotGetir2(notID)[0].NOTID.ToString();
            txtOgrenciAdSoyad.Text = dt.NotGetir2(notID)[0].OGRENCİADSOYAD;
            txtDersAd.Text = dt.NotGetir2(notID)[0].DERSAD;
            txtSinav1.Text = dt.NotGetir2(notID)[0].SINAV1.ToString();
            txtSinav2.Text = dt.NotGetir2(notID)[0].SINAV2.ToString();
            txtSinav3.Text = dt.NotGetir2(notID)[0].SINAV3.ToString();
            txtOrtalama.Text = dt.NotGetir2(notID)[0].ORTALAMA.ToString();
            txtDurum.Text = dt.NotGetir2(notID)[0].DURUM.ToString();
        }


    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        double sinav1, sinav2, sinav3;
        double ortalama;
        sinav1 = Convert.ToInt32(txtSinav1.Text);
        sinav2 = Convert.ToInt32(txtSinav2.Text);
        sinav3 = Convert.ToInt32(txtSinav3.Text);

        ortalama = (sinav1 + sinav2 + sinav3) / 3;

        txtOrtalama.Text = ortalama.ToString("0.00");

        if(ortalama>=50)
        {
            txtDurum.Text = "True";
        }
        else
        {
            txtDurum.Text = "False";
        }
    }

    protected void btnOgrenciGuncelle_Click(object sender, EventArgs e)
    {
        DataSetTableAdapters.OgrNotlarTableAdapter dt = new DataSetTableAdapters.OgrNotlarTableAdapter();
        dt.NotGuncelle(byte.Parse(txtSinav1.Text),byte.Parse(txtSinav2.Text),byte.Parse(txtSinav3.Text),decimal.Parse(txtOrtalama.Text),bool.Parse(txtDurum.Text),int.Parse(notID.ToString()));
        Response.Redirect("NotListesi.aspx"); //işlemlerden sonra yönlendirmek istenilen komut
    }
}