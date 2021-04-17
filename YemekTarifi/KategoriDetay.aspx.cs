using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace YemekTarifi
{
    public partial class KategoriDetay : System.Web.UI.Page
    {
        SqlSinifi bgl = new SqlSinifi();
        string id = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Request.QueryString["Kategoriid"];
            SqlCommand komut = new SqlCommand("select * from tbl_yemekler where Kategoriid=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", id);
            SqlDataReader rd = komut.ExecuteReader();
            DataList2.DataSource = rd;
            DataList2.DataBind();
            bgl.baglanti().Close();
        }
    }
}