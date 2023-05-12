﻿namespace ProniaApp.Models
{
    public class ProductComment:BaseEntity
    {
        public string Name { get; set; }
        public string? Subject { get; set; }
        public string Message { get; set; }
        public string Email { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
