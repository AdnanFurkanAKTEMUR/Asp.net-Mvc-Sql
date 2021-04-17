using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace YemekTarifi
{
    public partial class AdminMesajlar : System.Web.UI.Page
    {
        SqlSinifi bgl = new SqlSinifi();
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("select * from tbl_mesaj", bgl.baglanti());
            SqlDataReader rd = kmt.ExecuteReader();
            DataList1.DataSource = rd;
            DataList1.DataBind();
        }

       
    }
}