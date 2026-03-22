using System;

class Product
{
    // Private field
    private double price;

    // Public property with validation
    public double Price
    {
        get { return price; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Price cannot be negative. Setting to 0.");
                price = 0;
            }
            else
            {
                price = value;
            }
        }
    }

    public string Name { get; set; }

    // Constructor
    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }

    // Virtual method for discount
    public virtual double CalculateDiscount()
    {
        return Price; // Default: no discount
    }
}

class Electronics : Product
{
    public Electronics(string name, double price) : base(name, price) { }

    public override double CalculateDiscount()
    {
        return Price - (Price * 0.05); // 5% discount
    }
}

class Clothing : Product
{
    public Clothing(string name, double price) : base(name, price) { }

    public override double CalculateDiscount()
    {
        return Price - (Price * 0.15); // 15% discount
    }
}

class Program
{
    static void Main()
    {
        // Sample input
        Product laptop = new Electronics("Laptop", 20000);
        Product shirt = new Clothing("Shirt", 2000);

        // Polymorphic behavior
        Console.WriteLine($"Final Price of {laptop.Name} after discount = {laptop.CalculateDiscount()}");
        Console.WriteLine($"Final Price of {shirt.Name} after discount = {shirt.CalculateDiscount()}");
    }
}
