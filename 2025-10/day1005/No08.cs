namespace Daily_Algorithm._2025_10.day1005;

// [문제 설명] 하샤드 수
// https://school.programmers.co.kr/learn/courses/30/lessons/12947

public class No08
{
    public bool solution(int x)
    {
        int num = x;
        int sum = 0;

        while (num > 0)
        {
            sum += num % 10;
            num /= 10;
        }

        if (sum == 0) return false;
        
        return x % sum == 0;
    }
}