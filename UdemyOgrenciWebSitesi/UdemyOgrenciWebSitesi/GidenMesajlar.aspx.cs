﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GidenMesajlar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataSetTableAdapters.tbl_mesajlarTableAdapter dt = new DataSetTableAdapters.tbl_mesajlarTableAdapter();
        Repeater1.DataSource = dt.OgretmenGidenMesajlar();
        Repeater1.DataBind();

    }
}