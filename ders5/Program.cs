
namespace Field.Example;
public class Product
{
    public Product() { }
    public Product(string Name, decimal DiscountedPrice)
    {
        this.Name = Name;
        this.DiscountedPrice = DiscountedPrice;
    }

    public string name; // field public ve private olabilir
    public string Name
    {
        get
        {
            return name; // getter
        }
        set
        {
            name = value; // setter
        }
    }
    public string Description { get; set; } // normal standart property

    private decimal price; // private field
    private decimal rate = 20; // private field faakt default bir değer verilmiş
    public decimal Price
    {
        get
        {
            return price * rate; // getter return price * rate
        }
        set
        {
            if (value < 0) //value<0
            {
                throw new ArgumentException("Price cannot be negative");
            }
            price = value; // setter price = value
        }
    }

    // rich domain model
    public decimal DiscountedPrice { get; private set; }
    public void SetDiscount(decimal _discountedPrice)
    {
        if (_discountedPrice < 0)
        {
            throw new ArgumentException("Discounted price cannot be negative");
        }
        DiscountedPrice = _discountedPrice;
    }
}
