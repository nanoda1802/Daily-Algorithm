namespace Daily_Algorithm._2025_11.day1130;

public class Test
{
    public static void Main()
    {
        var a = new No01();
        foreach (var VARIABLE in a.solution(new string[,]{{"OOOOO", "OOOOO", "OPOPO", "OOOOO", "OOOOO"}}))
        {
            Console.WriteLine(VARIABLE);
        }
        
        Console.WriteLine(a.solution(new string[,]{{"OOOOO", "OOOOO", "OPOPO", "OOOOO", "OOOOO"}}));
        
        // PriorityQueue1 pq = new PriorityQueue1(10);
        //
        // for (int i = 1; i <= 20; i++) pq.Enqueue(i);
        // pq.Print();
        // Console.WriteLine("Count " + pq.Count);
        // Console.WriteLine("Peek " + pq.Peek());
        // Console.WriteLine("Dequeue " + pq.Dequeue());
        //
        // pq.Print();
        // Console.WriteLine("Count " + pq.Count);
        //
        // if (pq.TryPeek(out int item))
        // {
        //     Console.WriteLine("TryPeek " + item);
        //     if (pq.TryDequeue(out item))
        //     {
        //         Console.WriteLine("TryDequeue " + item);
        //     }
        // }
        //
        // while (pq.TryPeek(out item))
        // {
        //     Console.WriteLine("While Dequeue" + pq.Dequeue());
        // }
        //
        // pq.Print();
        // Console.WriteLine("Count " + pq.Count);
    }
}

class Me
{
    public delegate void Introduce(string name);
    public Introduce introduce;

    public Me()
    {
        introduce += PrintName;
        introduce += PrintAge;
        introduce += PrintHobby;
    }

    private void PrintName(string name) => Console.WriteLine($"저는 {name} 입니다.");

    private void PrintAge(string name) => Console.WriteLine($"{name}은 20살입니다.");

    private void PrintHobby(string name) => Console.WriteLine($"{name}은 운동을 좋아합니다.");
}

public delegate void Alert();

class Store
{
    private int price = 1000;
    public event Alert OnSell;

    public void Sell(Customer customer)
    {
        customer.money -= price;
        OnSell.Invoke();
    }
}

class Customer
{
    private string name;
    public int money { get; set; } = 10000;

    public Customer(string name, Store store)
    {
        this.name = name;
        store.OnSell += SendAlert;
    }

    private void SendAlert()
    {
        Console.WriteLine($"{name} 님이 물건을 구매해씀다. 남은 돈 : {money}");
    }
}
