namespace TelApp.WebUI.Model
{
    public class Product
    {
        public int ProductId {get;set;}
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public bool isApproved { get; set; }
        public string ImageUrl {get;set;}
    }
}