﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataSetTableAdapters.tbl_ogrencilerTableAdapter dt = new DataSetTableAdapters.tbl_ogrencilerTableAdapter();
        Repeater1.DataSource = dt.OgrenciListesi();
        Repeater1.DataBind();
    }
}