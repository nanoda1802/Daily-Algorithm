using Daily_Algorithm._2025_09.day0909;

namespace Daily_Algorithm;

public class Test
{
    delegate void Act();
    
    public static void Main()
    {
        No08 a= new No08();
        a.Print(new int[]{0,1,2,3,4,5},new int[]{4,1,2});


        Act act = new Act(Animal.Walk);
        
        act -= Animal.Walk;
        act += Animal.Walk;
    }
}


class Animal
{
    public static void Walk()
    {
        
    }
}

