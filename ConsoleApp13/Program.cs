namespace ConsoleApp13;


abstract class Vehicle
{
    public string brand;
    public int speed;
    public abstract void Move();
}
class Car : Vehicle
{
    public override void Move()
    {
        Console.WriteLine("Car drives");
    }
    
}
class Bicycle : Vehicle
{
    public override void Move()
    {
        Console.WriteLine("Bicycle is pedaling");
    }
    
}
 
class Airplane : Vehicle
{
    public override void Move()
    {
        Console.WriteLine("Airplane flies");
    }
    
}