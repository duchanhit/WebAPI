﻿namespace WebAPI.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        // Other properties
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
