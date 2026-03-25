
using System.Text;

interface IRefuelable
{
    void Refill();
}

abstract class Vehicle
{
    public string Brand { get; set; }
    public int Speed { get; set; }

    public Vehicle(string brand, int speed)
    {
        Brand = brand;
        Speed = speed;
    }

    public abstract void Move();
}

class Car : Vehicle, IRefuelable
{
    public Car(string brand, int speed) : base(brand, speed) { }

    public override void Move()
    {
        Console.WriteLine($"Автомобіль {Brand} їде дорогою зі швидкістю {Speed} км/год.");
    }

    public void Refill()
    {
        Console.WriteLine($"Автомобіль {Brand} заправляється паливом.");
    }
}

class Bicycle : Vehicle
{
    public Bicycle(string brand, int speed) : base(brand, speed) { }

    public override void Move()
    {
        Console.WriteLine($"Велосипед {Brand} рухається зі швидкістю {Speed} км/год.");
    }
}

class Airplane : Vehicle, IRefuelable
{
    public Airplane(string brand, int speed) : base(brand, speed) { }

    public override void Move()
    {
        Console.WriteLine($"Літак {Brand} летить зі швидкістю {Speed} км/год.");
    }

    public void Refill()
    {
        Console.WriteLine($"Літак {Brand} заправляється авіаційним паливом.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        List<Vehicle> vehicles = new List<Vehicle>
        {
            new Car("Toyota", 120),
            new Bicycle("Giant", 25),
            new Airplane("Boeing", 800)
        };

        foreach (var vehicle in vehicles)
        {
            vehicle.Move();
        }

        Console.WriteLine();

        foreach (var vehicle in vehicles)
        {
            if (vehicle is IRefuelable refuelable)
            {
                refuelable.Refill();
            }
        }
    }
}