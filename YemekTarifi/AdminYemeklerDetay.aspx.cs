using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace YemekTarifi
{

    public partial class AdminYemeklerDetay : System.Web.UI.Page
    {
        
        SqlSinifi bgl = new SqlSinifi();
        string id;
        string kid;
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Request.QueryString["Yemekid"];
            kid= Request.QueryString["Kategoriid"];
            if (Page.IsPostBack == false)
            {
                SqlCommand kmt = new SqlCommand("select * from tbl_yemekler where Yemekid=@p1", bgl.baglanti());
                kmt.Parameters.AddWithValue("@p1", id);
                SqlDataReader rd = kmt.ExecuteReader();
                while (rd.Read())
                {
                    TextBox1.Text = rd[1].ToString();
                    TextBox2.Text = rd[2].ToString();
                    TextBox3.Text = rd[3].ToString();
                    DropDownList1.SelectedValue = rd[7].ToString();
                }

                bgl.baglanti().Close();

                SqlCommand kmt2 = new SqlCommand("select * from tbl_kategoriler", bgl.baglanti());
                SqlDataReader rd2 = kmt2.ExecuteReader();
                DropDownList1.DataTextField = "KategoriAd";
                DropDownList1.DataValueField = "Kategoriid";

                DropDownList1.DataSource = rd2;
                DropDownList1.DataBind();
            }
               
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand guncelle = new SqlCommand("UPDATE tbl_yemekler SET YemekAd=@p1, YemekMalzeme=@p2, YemekTarif=@p3, Kategoriid=@p4 WHERE Yemekid=@p5",bgl.baglanti());
            guncelle.Parameters.AddWithValue("@p1", TextBox1.Text);
            guncelle.Parameters.AddWithValue("@p2", TextBox2.Text);
            guncelle.Parameters.AddWithValue("@p3", TextBox3.Text);
            guncelle.Parameters.AddWithValue("@p4", DropDownList1.SelectedValue);
            guncelle.Parameters.AddWithValue("@p5", id);
            guncelle.ExecuteNonQuery();
            bgl.baglanti().Close();

            SqlCommand artir = new SqlCommand("Update tbl_kategoriler set KategoriAdet=KategoriAdet+1 where Kategoriid=@p1", bgl.baglanti());
            artir.Parameters.AddWithValue("@p1", DropDownList1.SelectedValue);
            artir.ExecuteNonQuery();
            bgl.baglanti().Close();

            SqlCommand sil=new SqlCommand("Update tbl_kategoriler set KategoriAdet=KategoriAdet-1 where Kategoriid=@p1", bgl.baglanti());
            sil.Parameters.AddWithValue("@p1", kid);
            sil.ExecuteNonQuery();
            bgl.baglanti().Close();
            Response.Redirect("AdminYemeklerDetay.aspx?Yemekid="+id);
        }

        
    }
}