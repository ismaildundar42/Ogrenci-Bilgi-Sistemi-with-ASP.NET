﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DersEkle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void btnDersEkle_Click(object sender, EventArgs e)
    {
        DataSetTableAdapters.tbl_derslerTableAdapter dt = new DataSetTableAdapters.tbl_derslerTableAdapter();
        dt.DersEkle(txtDersAdı.Text);
        Response.Redirect("DersListesi.aspx");
    }
}