namespace Daily_Algorithm._2025_09.day0905;

// [문제 설명] 공배수
// https://school.programmers.co.kr/learn/courses/30/lessons/181936

public class No06
{
    public int Print(int number, int n, int m)
    {
        return number % n == 0 && number % m == 0 ? 1 : 0;
    }
}

// [다른풀이1 - ShortCircuit] 
/*
    if(number % n != 0) return 0;
    if(number % m != 0) return 0;
    return 1;
*/