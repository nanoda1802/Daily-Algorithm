using Daily_Algorithm._2025_11.day1113;

namespace Daily_Algorithm;

public class Test
{
    public static void Main()
    {
        var a= new No01();
        Console.WriteLine(a.solution([180, 5000, 10, 600], ["05:34 5961 IN", "06:00 0000 IN", "06:34 0000 OUT", "07:59 5961 OUT", "07:59 0148 IN", "18:59 0000 IN", "19:09 0148 OUT", "22:59 5961 IN", "23:00 5961 OUT"]));
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