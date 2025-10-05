namespace Daily_Algorithm._2025_10.day1005;

// [문제 설명] 없는 숫자 더하기
// https://school.programmers.co.kr/learn/courses/30/lessons/86501

public class No12
{
    public  int solution(int[] numbers)
    {
        int total = 45;

        foreach (int num in numbers)
        {
            total -= num;
        }
        
        return total;
    }
}

// [다른풀이1 - Linq] "Except"란 메서드!
/*
    var numberArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    return numberArray.Except(numbers).Sum();
*/ 