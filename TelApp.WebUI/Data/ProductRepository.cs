using System.Collections.Generic;
using System.Linq;
using TelApp.WebUI.Model;

namespace TelApp.WebUI.Data
{
    public static class ProductRepository
    {
        private static List<Product> _products=null;

        static ProductRepository(){
            _products=new List<Product>{
                new Product{ProductId=1,Name="Samsung",Description="İyi telefon",Price=1500,isApproved=true,ImageUrl="1.jpg"},
                new Product{ProductId=2,Name="Iphone",Description="İyi telefon",Price=1700,isApproved=true,ImageUrl="2.jpg"},
                new Product{ProductId=3,Name="Xioami",Description="İyi telefon",Price=1300,isApproved=true,ImageUrl="3.jpg"},
                new Product{ProductId=4,Name="Motorola",Description="iyi telefon",Price=2000,isApproved=true,ImageUrl="4.jpg"},
                new Product{ProductId=5,Name="Iphone xs",Description="İyi telefon",Price=12000,isApproved=false,ImageUrl="5.jpg"}
            };
        }

        public static List<Product> Products {get{
            return _products;
        }}

        public static void addProduct(Product product){
            _products.Add(product);
        }
        public static Product GetProductById(int id){
            return _products.FirstOrDefault(item=>item.ProductId==id);
        }
    }
}