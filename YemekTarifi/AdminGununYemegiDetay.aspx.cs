using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace YemekTarifi
{
    public partial class AdminGununYemegiDetay : System.Web.UI.Page
    {
        SqlSinifi bgl = new SqlSinifi();
        string id;
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Request.QueryString["Yemekid"];
            if (Page.IsPostBack == false)
            {
                SqlCommand getir = new SqlCommand("select * from tbl_yemekler where Yemekid=@p1", bgl.baglanti());
                getir.Parameters.AddWithValue("@p1", id);
                SqlDataReader rd = getir.ExecuteReader();
                while (rd.Read())
                {
                    TextBox1.Text = rd[1].ToString();
                    TextBox2.Text = rd[2].ToString();
                    TextBox3.Text = rd[3].ToString();
                    TextBox4.Text = rd[5].ToString();
                    TextBox5.Text = rd[6].ToString();
                    TextBox6.Text = rd[8].ToString();
                }
                bgl.baglanti().Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand eskiGununYemegi = new SqlCommand("update tbl_yemekler set YemekDurum=0  where YemekDurum=1", bgl.baglanti());
            eskiGununYemegi.ExecuteNonQuery();
            bgl.baglanti().Close();

            SqlCommand yeniGununYemegi = new SqlCommand("update tbl_yemekler set YemekDurum=1  where Yemekid=@p1", bgl.baglanti());
            yeniGununYemegi.Parameters.AddWithValue("@p1", id);
            yeniGununYemegi.ExecuteNonQuery();
            bgl.baglanti().Close();
            Response.Redirect("AdminGununYemegiDetay.aspx?Yemekid=" + id);
           

        }
    }
}