namespace Daily_Algorithm._2025_09.day0921;

// [문제 설명] 제곱수 판별하기
// https://school.programmers.co.kr/learn/courses/30/lessons/120909

public class No15
{
    public  int solution(int n) 
    {
        // 제곱수 특징 : 약수의 개수가 홀수임
        // 근데 그 전에 바로 찾는 게 나은 듯
        
        for (int i = 1; i*i <= n; i++)
        {
            if (i * i == n) return 1;
        }

        return 2;
    }
}