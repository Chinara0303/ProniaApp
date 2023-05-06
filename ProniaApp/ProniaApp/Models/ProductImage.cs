namespace ProniaApp.Models
{
    public class ProductImage:BaseEntity
    {
        public string ImgName { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
