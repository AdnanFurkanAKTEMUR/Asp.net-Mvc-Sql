using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace YemekTarifi
{
    public partial class AdminYorumlarDetay : System.Web.UI.Page
    {
        SqlSinifi bgl = new SqlSinifi();
        string id;
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Request.QueryString["Yorumid"];
            if (Page.IsPostBack == false)
            {
                SqlCommand komut = new SqlCommand("Select YorumAdSoyad, YorumMail, YorumTarih, YorumOnay, YorumIcerik, YemekAd from tbl_yorumlar inner join tbl_yemekler on tbl_yorumlar.yemekid=tbl_yemekler.yemekid where Yorumid=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", id);
                SqlDataReader rd = komut.ExecuteReader();
                while (rd.Read())
                {
                    TextBox1.Text = rd[0].ToString();
                    TextBox2.Text = rd[1].ToString();
                    TextBox3.Text = rd[2].ToString();
                    TextBox4.Text = rd[3].ToString();
                    TextBox5.Text = rd[4].ToString();
                    TextBox6.Text = rd[5].ToString();

                }
                bgl.baglanti().Close();
                TextBox3.Enabled = false;
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand guncelle = new SqlCommand("Update tbl_yorumlar set YorumOnay=@p3  where Yorumid=@p5", bgl.baglanti());
            guncelle.Parameters.AddWithValue("@p3", true);
            guncelle.Parameters.AddWithValue("@p5", id);
            guncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            Response.Redirect("AdminYorumlar.aspx");
        }
    }
}