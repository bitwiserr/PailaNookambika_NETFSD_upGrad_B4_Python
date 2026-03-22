using System;

class Vehicle
{
    // Private field
    private double rentalRatePerDay;

    // Public property with validation
    public double RentalRatePerDay
    {
        get { return rentalRatePerDay; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Rental rate cannot be negative. Setting to 0.");
                rentalRatePerDay = 0;
            }
            else
            {
                rentalRatePerDay = value;
            }
        }
    }

    public string Brand { get; set; }

    // Constructor
    public Vehicle(string brand, double rate)
    {
        Brand = brand;
        RentalRatePerDay = rate;
    }

    // Virtual method for rental calculation
    public virtual double CalculateRental(int days)
    {
        if (days <= 0)
        {
            Console.WriteLine("Invalid number of days. Must be greater than 0.");
            return 0;
        }
        return RentalRatePerDay * days;
    }
}

class Car : Vehicle
{
    public Car(string brand, double rate) : base(brand, rate) { }

    public override double CalculateRental(int days)
    {
        if (days <= 0)
        {
            Console.WriteLine("Invalid number of days. Must be greater than 0.");
            return 0;
        }
        // Add insurance charge of 500
        return (RentalRatePerDay * days) + 500;
    }
}

class Bike : Vehicle
{
    public Bike(string brand, double rate) : base(brand, rate) { }

    public override double CalculateRental(int days)
    {
        if (days <= 0)
        {
            Console.WriteLine("Invalid number of days. Must be greater than 0.");
            return 0;
        }
        double total = RentalRatePerDay * days;
        // Apply 5% discount
        return total - (total * 0.05);
    }
}

class Program
{
    static void Main()
    {
        // Sample input
        Vehicle car = new Car("Toyota", 2000);
        Vehicle bike = new Bike("Honda", 500);

        // Polymorphic calls
        Console.WriteLine($"Car Rental (3 days) = {car.CalculateRental(3)}");
        Console.WriteLine($"Bike Rental (5 days) = {bike.CalculateRental(5)}");
    }
}
