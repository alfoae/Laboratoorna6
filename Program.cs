
interface ITryOn
{
    void TryOn();
}

abstract class Clothing
{
    public string Name { get; set; }
    public string Size { get; set; }

    public Clothing(string name, string size)
    {
        Name = name;
        Size = size;
    }

    public abstract void CheckSize(string desiredSize);
}

class Shirt : Clothing, ITryOn
{
    public Shirt(string name, string size) : base(name, size) { }

    public override void CheckSize(string desiredSize)
    {
        if (Size == desiredSize)
            Console.WriteLine($"Сорочка {Name}: розмір підходить!");
        else
            Console.WriteLine($"Сорочка {Name}: розмір не підходить (має {Size})");
    }

    public void TryOn()
    {
        Console.WriteLine($"Приміряємо сорочку {Name}");
    }
}

class Trousers : Clothing, ITryOn
{
    public Trousers(string name, string size) : base(name, size) { }

    public override void CheckSize(string desiredSize)
    {
        if (Size == desiredSize)
            Console.WriteLine($"Штани {Name}: розмір підходить!");
        else
            Console.WriteLine($"Штани {Name}: розмір не підходить (має {Size})");
    }

    public void TryOn()
    {
        Console.WriteLine($"Приміряємо штани {Name}");
    }
}

class Jacket : Clothing, ITryOn
{
    public Jacket(string name, string size) : base(name, size) { }

    public override void CheckSize(string desiredSize)
    {
        if (Size == desiredSize)
            Console.WriteLine($"Куртка {Name}: розмір підходить!");
        else
            Console.WriteLine($"Куртка {Name}: розмір не підходить (має {Size})");
    }

    public void TryOn()
    {
        Console.WriteLine($"Приміряємо куртку {Name}");
    }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Clothing[] clothes = new Clothing[]
        {
            new Shirt("Nike", "M"),
            new Trousers("Adidas", "L"),
            new Jacket("Puma", "XL")
        };

        string desiredSize = "M";

        foreach (var item in clothes)
        {
            item.CheckSize(desiredSize);
        }

        Console.WriteLine();

        foreach (var item in clothes)
        {
            if (item is ITryOn tryOn)
                tryOn.TryOn();
        }
    }
}