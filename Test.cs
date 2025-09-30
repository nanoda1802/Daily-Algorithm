using Daily_Algorithm._2025_09.day0929;

namespace Daily_Algorithm;

public class Test
{
    public static void Main()
    {
        var a= new No05();
        Console.Write(a.solution("x + 5"));
        

        // Me me = new Me();
        // me.introduce("Tom");
        //
        // Predicate<int> isEven = i => i % 2 == 0;
        // bool check = isEven(5); // false
        //
        // Func<int,int,string> add = (x,y) => $"{x} 더하기 {y}는 {x+y} 입니다.";
        // Console.WriteLine(add(3,5));
        //
        // Action<string> introduce = name => Console.WriteLine($"저는 {name} 입니다.");
        // introduce("Tom");
        //
        // Store store = new Store();
        // Customer customer = new Customer("Tom", store);
        // store.Sell(customer);
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