using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace YemekTarifi
{
    public partial class AdminMesajlarDetay : System.Web.UI.Page
    {
        string id;
        SqlSinifi bgl = new SqlSinifi();
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Request.QueryString["Mesajid"];

            if (Page.IsPostBack == false)
            {
                SqlCommand doldur = new SqlCommand("Select * from tbl_mesaj where Mesajid=@p1", bgl.baglanti());
                doldur.Parameters.AddWithValue("@p1", id);
                SqlDataReader rd = doldur.ExecuteReader();

                while (rd.Read())
                {
                    TextBox1.Text = rd[4].ToString();
                    TextBox2.Text = rd[1].ToString();
                    TextBox3.Text = rd[2].ToString();
                    TextBox4.Text = rd[3].ToString();
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand sil = new SqlCommand("Delete from tbl_mesaj where Mesajid=@p1", bgl.baglanti());
            sil.Parameters.AddWithValue("@p1", id);
            sil.ExecuteNonQuery();
            bgl.baglanti().Close();
            Response.Redirect("AdminMesajlar.aspx");
        }
    }
}