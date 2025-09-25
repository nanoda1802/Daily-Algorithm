namespace Daily_Algorithm._2025_09.day0925;

// [문제 설명] 팩토리얼
// https://school.programmers.co.kr/learn/courses/30/lessons/120848

public class No03
{
    public int solution(int n)
    {

        int acc = 1;
        int answer = 0;
        
        for (int i = 1; i <= n; i++)
        {
            acc *= i;
            
            if (acc > n)
            {
                answer = i - 1;
                break;
            }
            
            if (acc == n)
            {
                answer = i;
                break;
            }
        }
        
        return answer;
    }
}

// [메모] 순진하게 팩토리얼 구현하지 않은 점 칭찬혀!
