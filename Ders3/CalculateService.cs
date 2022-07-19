namespace Calculate
{
    public class CalculateService
    {
        public decimal Kg { get; set; }
        public decimal Price { get; set; }
        public decimal CalculatePrice()
        {
            return Kg * Price;
        }
    }
}