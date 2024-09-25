using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OgrenciNotu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataSetTableAdapters.tbl_ogrencilerTableAdapter dt = new DataSetTableAdapters.tbl_ogrencilerTableAdapter();
        Repeater1.DataSource = dt.OgrencininNotu("1004");
        Repeater1.DataBind();

    }
}