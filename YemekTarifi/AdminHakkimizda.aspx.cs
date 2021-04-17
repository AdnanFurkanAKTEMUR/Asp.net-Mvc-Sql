using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace YemekTarifi
{
    public partial class AdminHakkimizda : System.Web.UI.Page
    {
        SqlSinifi bgl = new SqlSinifi();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack==false)
            {
                SqlCommand kmt = new SqlCommand("select * from Tbl_Hakkimizda", bgl.baglanti());
                SqlDataReader rd = kmt.ExecuteReader();
                while (rd.Read())
                {
                    TextBox1.Text = rd[0].ToString();
                }
                bgl.baglanti().Close();
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("Update tbl_Hakkimizda set Metin=@p1", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", TextBox1.Text);
            kmt.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
    }
}