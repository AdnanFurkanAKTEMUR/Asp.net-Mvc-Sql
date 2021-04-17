using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YemekTarifi
{
    public partial class GununYemegi : System.Web.UI.Page
    {
        SqlSinifi bgl = new SqlSinifi();
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Yemekler where YemekDurum=1", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            
            DataList2.DataSource = oku;
            DataList2.DataBind();
        }
    }
}