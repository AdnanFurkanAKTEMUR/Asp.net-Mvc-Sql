using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace YemekTarifi
{
    public partial class AdminTarifOner : System.Web.UI.Page
    {
        SqlSinifi bgl = new SqlSinifi();
        string id;
        string islem;
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("select * from tbl_tarifler where TarifDurum=0", bgl.baglanti());
            SqlDataReader rd = kmt.ExecuteReader();
            DataList1.DataSource = rd;
            DataList1.DataBind();
            bgl.baglanti().Close();

            SqlCommand kmt2 = new SqlCommand("select * from tbl_tarifler where TarifDurum=1", bgl.baglanti());
            SqlDataReader rd2 = kmt2.ExecuteReader();
            DataList2.DataSource = rd2;
            DataList2.DataBind();
            bgl.baglanti().Close();

            if (Page.IsPostBack == false)
            {
                id = Request.QueryString["Tarifid"];
                islem = Request.QueryString["islem"];
            }
            if (islem == "sil")
            {
                SqlCommand sil = new SqlCommand("delete from tbl_tarifler where Tarifid=@p1", bgl.baglanti());
                sil.Parameters.AddWithValue("@p1", id);
                sil.ExecuteNonQuery();
                bgl.baglanti().Close();
                Response.Redirect("AdminTarifOner.aspx");
            }
        }
    }
}