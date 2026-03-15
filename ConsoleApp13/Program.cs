namespace ConsoleApp13;




class Program
{
    static void Main()
    {
        List<Cookware> kitchen = new List<Cookware>()
        {
            new Pan("Tefal", 180),
            new Pot("Bosch", 100),
            new Kettle("Philips", 100)
        };

        foreach (Cookware item in kitchen)
        {
            item.Cook();

            if (item is Refillable refillable)
            {
                refillable.Refill();
            }

            Console.WriteLine();
        }
    }
}

abstract class Cookware
{
    public string brand;
    public int temperature;

    public Cookware(string brand, int temperature)
    {
        this.brand = brand;
        this.temperature = temperature;
    }

    public abstract void Cook();
}

interface Refillable
{
    void Refill();
}

class Pan : Cookware
{
    public Pan(string brand, int temperature) : base(brand, temperature) { }

    public override void Cook()
    {
        Console.WriteLine($"Pan {brand} is frying food at {temperature}°C");
    }
}

class Pot : Cookware, Refillable
{
    public Pot(string brand, int temperature) : base(brand, temperature) { }

    public override void Cook()
    {
        Console.WriteLine($"Pot {brand} is boiling soup at {temperature}°C");
    }

    public void Refill()
    {
        Console.WriteLine($"Pot {brand} is filled with water");
    }
}

class Kettle : Cookware, Refillable
{
    public Kettle(string brand, int temperature) : base(brand, temperature) { }

    public override void Cook()
    {
        Console.WriteLine($"Kettle {brand} is boiling water at {temperature}°C");
    }

    public void Refill()
    {
        Console.WriteLine($"Kettle {brand} is refilled with water");
    }
}

