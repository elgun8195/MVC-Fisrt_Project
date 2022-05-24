namespace WebApplication1.Models
{
    public class Product
    {
        private static int _id;
        public int Id { get; }
        public string Descript { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public Product()
        {
            Id = ++_id;
        }
    }
}
