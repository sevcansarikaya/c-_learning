namespace Envanter
{
    public class Product
    {
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountedPrice { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}