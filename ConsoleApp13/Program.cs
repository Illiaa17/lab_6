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
