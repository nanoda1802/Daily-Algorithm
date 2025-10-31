using Daily_Algorithm._2025_10.day1030;

namespace Daily_Algorithm;

public class Test
{
    public static void Main()
    {
        int[] nums = { 4, 6, 7, 9, 3, 1 };
        Sort.SelectionSort(nums);
        foreach (int num in nums)
        {
            Console.Write(num);
        }

        // var a= new No03();
        // Console.WriteLine(a.solution(80,new int[,]{{80,20},{50,40},{30,10}}	));
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