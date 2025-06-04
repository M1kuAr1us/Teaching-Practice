namespace UML_Classes;

public class OnlineStore
{
    static private Goods cabel = new Goods()
    {
        Id = 223344,
        Name = "Cabel",
        Description = "charging cabel.",
        Price = 4.5
    };
    static private Goods earphones = new Goods()
    {
        Id = 223388,
        Name = "Earphones",
        Description = "Phone earphones.",
        Price = 15.0
    };
    static private Goods pencil = new Goods()
    {
        Id = 223355,
        Name = "Pencil",
        Description = "Koh-i-nor pencil.",
        Price = 0.3
    };
    static private Goods pen = new Goods()
    {
        Id = 223366,
        Name = "Pen",
        Description = "Gel pen.",
        Price = 0.3
    };
    static private Goods copybook = new Goods()
    {
        Id = 223377,
        Name = "Copybook",
        Description = "12-page copybook",
        Price = 0.5
    };
    
    static public void OnlineStoreMain()
    {
        Client client1 = new Client()
        {
            Id = 1234567800,
            Name = "John",
            Address = "123 Main St.",
            Email = "egamplebox@email.com"
        };
        
        client1.Add(pencil);
        client1.Add(pen);
        client1.Add(pen);
        client1.Add(copybook);
        client1.Add(copybook);
        client1.Add(copybook);
        client1.Add(cabel);
        client1.Add(earphones);
        
        client1.PlaceOrder(client1, client1.goods);
    }
}

public class Goods
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public string Description { get; set; }

    public double GetPrice()
    {
        return Price;
    }
}

public class Client : Basket
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }

    public void PlaceOrder(Client client, List<Goods> goods)
    {
        Order clientOrder = new Order()
        {
            Id = RandNumber(),
            Client = client,
            Goods = goods,
            Date = DateTime.Now,
            Status = "Created"
        };
        
        Console.WriteLine($"Price: {clientOrder.GetTotal()}");
        Console.WriteLine("Start payment? (y - Yes): ");
        Console.ReadLine();

        Payment client1Payment = new Payment()
        {
            Id = RandNumber(),
            Sum = clientOrder.GetTotal(),
            Date = DateTime.Now,
            Status = "Created"
        };
        
        Console.WriteLine($"Id: {client1Payment.Id}");
        Console.WriteLine($"Payment date: {client1Payment.Date}");
        
        Console.WriteLine("Pay for the order? (y - Yes): ");
        Console.ReadLine();
        client1Payment.Pay();
        
        client1Payment.Status = "paid";
        Console.WriteLine($"Payment status: {client1Payment.Status}");
        clientOrder.Status = "being completed";
        Console.WriteLine($"Order status: {clientOrder.Status}");
        
        Console.WriteLine("Order payment successful!");
    }
    
    static private int RandNumber()
    {
        Random random = new Random();
        return random.Next(100000, 777777);
    }
}

public class Basket
{
    public List<Goods> goods = new List<Goods>();

    public void Add(Goods item)
    {
        goods.Add(item);
    }

    public void Remove(Goods item)
    {
        goods.Remove(item);
    }

    public double GetTotal()
    {
        double total = 0;
        foreach (var item in goods)
        {
            total += item.GetPrice();
        }
        return total;
    }
}

public class Order
{
    public int Id { get; set; }
    public Client Client { get; set; }
    public List<Goods> Goods { get; set; }
    public DateTime Date { get; set; }
    public string Status { get; set; }

    public double GetTotal()
    {
        double total = 0;
        foreach (var item in Goods)
        {
            total += item.GetPrice();
        }

        return total;
    }
}

public class Payment
{
    public int Id { get; set; }
    public double Sum { get; set; }
    public DateTime Date { get; set; }
    public string Status { get; set; }

    public void Pay()
    {
        Console.WriteLine("Payment sucsessfully.");
    }
}