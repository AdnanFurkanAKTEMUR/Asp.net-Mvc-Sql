using System.Collections.Generic;
using System.Linq;
using TelApp.WebUI.Model;

namespace TelApp.WebUI.Data

{
    public static class CategoryRepository
    {
        private static List<Category> _category=null;

        static CategoryRepository(){
            _category=new List<Category>{
                new Category{CategoryId=1,Name="Telefonlar",Description="Telefon kategorisi"},
                new Category{CategoryId=1,Name="Bilgisayarlar",Description="Bilgisayar kategorisi"},
                new Category{CategoryId=1,Name="Elektronik",Description="Elektronik kategorisi"}
            };
        }

        public static List<Category> Categories {get{
            return _category;
        }}

        public static void addCategory(Category category){
            _category.Add(category);
        }

        public static Category GetCategoryByName(int id){
            return _category.FirstOrDefault(item=>item.CategoryId==id);
        }
    }
}