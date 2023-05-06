namespace ProniaApp.Models
{
    public class ProductCategory:BaseEntity
    {
        public int ProudctId { get; set; }
        public int CategoryId { get; set; }
        public Product Product { get; set; }
        public Category Category { get; set; }
    }
}
