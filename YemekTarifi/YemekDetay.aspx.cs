using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace YemekTarifi
{
    public partial class YemekDetay : System.Web.UI.Page
    {
        SqlSinifi bgl = new SqlSinifi();
        string yemekid = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            yemekid = Request.QueryString["yemekid"];
            SqlCommand komut = new SqlCommand("Select * From tbl_Yemekler where yemekid=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", yemekid);
            SqlDataReader rd = komut.ExecuteReader();
            DataList3.DataSource = rd;
            DataList3.DataBind();
            bgl.baglanti().Close();


            SqlCommand komut2 = new SqlCommand("Select * From tbl_Yorumlar where yemekid=@p2", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p2", yemekid);
            SqlDataReader rd2 = komut2.ExecuteReader();
            DataList2.DataSource = rd2;
            DataList2.DataBind();
            bgl.baglanti().Close();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand ekle = new SqlCommand("insert into tbl_yorumlar (YorumAdSoyad,YorumMail,YorumIcerik,Yemekid) values (@p1,@p2,@p3,@p4)",bgl.baglanti());
            ekle.Parameters.AddWithValue("@p1",TextBox1.Text);
            ekle.Parameters.AddWithValue("@p2", TextBox2.Text);
            ekle.Parameters.AddWithValue("@p3", TextBox3.Text);
            ekle.Parameters.AddWithValue("@p4", yemekid);
            ekle.ExecuteNonQuery();
            bgl.baglanti().Close();
            TextBox1.Text = ""; TextBox2.Text = ""; TextBox3.Text = "";


        }
    }
}