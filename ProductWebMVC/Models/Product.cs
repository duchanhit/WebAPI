namespace ProductWebMVC.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string Description { get; set; } = string.Empty;
        // Nếu có trường nào khác ở WebAPI thì thêm vào đây
    }
}
