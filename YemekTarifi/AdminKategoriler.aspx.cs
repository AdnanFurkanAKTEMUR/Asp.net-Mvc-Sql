using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace YemekTarifi
{
    public partial class AdminKategoriler : System.Web.UI.Page
    {
        SqlSinifi bgl = new SqlSinifi();
        string islem = "";
        string id = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                islem = Request.QueryString["islem"];
                id = Request.QueryString["Kategoriid"];
            }

            SqlCommand komut = new SqlCommand("select * from tbl_kategoriler", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            DataList1.DataSource = dr;
            DataList1.DataBind();
            bgl.baglanti().Close();

            if (islem == "sil")
            {
                SqlCommand sil = new SqlCommand("delete from tbl_kategoriler where Kategoriid=@p1", bgl.baglanti());
                sil.Parameters.AddWithValue("@p1", id);
                sil.ExecuteNonQuery();
                bgl.baglanti().Close();
                Response.Redirect("AdminKategoriler.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
                SqlCommand komut = new SqlCommand("insert into Tbl_Kategoriler (KategoriAd) values (@p1)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TextBox1.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                TextBox1.Text = "";
                Response.Redirect("AdminKategoriler.aspx");

        }
    }
}