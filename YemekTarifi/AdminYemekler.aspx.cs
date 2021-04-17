using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace YemekTarifi
{
    public partial class AdminYemekler : System.Web.UI.Page
    {
        SqlSinifi bgl = new SqlSinifi();
        string id;
        string kid;
        string islem;
        string value;
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("select * from tbl_yemekler", bgl.baglanti());
            SqlDataReader rd = komut1.ExecuteReader();
            DataList1.DataSource = rd;
            DataList1.DataBind();
            bgl.baglanti().Close();

            SqlCommand komut2 = new SqlCommand("Select * from tbl_kategoriler", bgl.baglanti());
            SqlDataReader rd2 = komut2.ExecuteReader();
            DropDownList1.DataTextField = "KategoriAd";
            DropDownList1.DataValueField = "Kategoriid";

            DropDownList1.DataSource = rd2;
            DropDownList1.DataBind();
            bgl.baglanti().Close();

            if (Page.IsPostBack == false)
            {
                id = Request.QueryString["Yemekid"];
                kid= Request.QueryString["Kategoriid"];
                islem = Request.QueryString["islem"];
            }
            if (islem == "sil")
            {
                SqlCommand sil = new SqlCommand("delete from tbl_yemekler where Yemekid=@p1", bgl.baglanti());
                sil.Parameters.AddWithValue("@p1", id);
                sil.ExecuteNonQuery();
                bgl.baglanti().Close();
                

                SqlCommand katSayisiDusur = new SqlCommand("update tbl_kategoriler set KategoriAdet=KategoriAdet-1 where Kategoriid=@p1", bgl.baglanti());
                katSayisiDusur.Parameters.AddWithValue("@p1", kid);
                katSayisiDusur.ExecuteNonQuery();
                bgl.baglanti().Close();
                Response.Redirect("AdminYemekler.aspx");

            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
                SqlCommand yemekKaydet = new SqlCommand("insert into tbl_yemekler (YemekAd,YemekMalzeme,YemekTarif,Kategoriid) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
                yemekKaydet.Parameters.AddWithValue("@p1", TextBox1.Text);
                yemekKaydet.Parameters.AddWithValue("@p2", TextBox2.Text);
                yemekKaydet.Parameters.AddWithValue("@p3", TextBox3.Text);
                yemekKaydet.Parameters.AddWithValue("@p4", DropDownList1.SelectedValue);
                yemekKaydet.ExecuteNonQuery();
                bgl.baglanti().Close();

                SqlCommand kategoriSayisiArtir = new SqlCommand("update tbl_kategoriler set KategoriAdet=KategoriAdet+1 where Kategoriid=@p1", bgl.baglanti());
                kategoriSayisiArtir.Parameters.AddWithValue("@p1", DropDownList1.SelectedValue);
                kategoriSayisiArtir.ExecuteNonQuery();
                bgl.baglanti().Close();
                Response.Redirect("AdminYemekler.aspx");         
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            value = DropDownList1.SelectedValue;
        }
    }
}