using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace YemekTarifi
{
    public partial class AdminYorumlar : System.Web.UI.Page
    {
        SqlSinifi bgl = new SqlSinifi();
        string id;
        string islem;
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand onaylanan = new SqlCommand("select * from tbl_yorumlar where YorumOnay=1", bgl.baglanti());
            SqlDataReader rd = onaylanan.ExecuteReader();
            DataList1.DataSource = rd;
            DataList1.DataBind();

            SqlCommand onaylanmayan = new SqlCommand("select * from tbl_yorumlar where YorumOnay=0", bgl.baglanti());
            SqlDataReader rd2 = onaylanmayan.ExecuteReader();
            DataList2.DataSource = rd2;
            DataList2.DataBind();

            if (Page.IsPostBack == false)
            {
                id = Request.QueryString["Yorumid"];
                islem = Request.QueryString["islem"];
            }
            if (islem == "sil")
            {
                SqlCommand yorumuSil = new SqlCommand("Delete  from tbl_yorumlar where Yorumid=@p1", bgl.baglanti());
                yorumuSil.Parameters.AddWithValue("@p1", id);
                yorumuSil.ExecuteNonQuery();
                bgl.baglanti().Close();
                Response.Redirect("AdminYorumlar.aspx");
            }
        }
    }
}