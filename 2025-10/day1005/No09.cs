namespace Daily_Algorithm._2025_10.day1005;

// [문제 설명] 정수 제곱근 판별
// https://school.programmers.co.kr/learn/courses/30/lessons/12934

public class No09
{
    public long solution(long n) {
        for (long i = 1; i*i <= n; i++)
        {
            if (i*i==n)
            {
                return (i + 1) * (i + 1);
            }
        }
        
        return -1;
    }
}