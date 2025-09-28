namespace Daily_Algorithm._2025_09.day0928;

// [문제 설명] K의 개수
// https://school.programmers.co.kr/learn/courses/30/lessons/120887

public class No05
{
    public int solution(int i, int j, int k)
    {
        int answer = 0;
        
        for (int n = i; n <= j; n++)
        {
            int num = n;
            while (num != 0)
            {
                if (num % 10 == k) answer += 1;
                num /= 10;
            }
        }
        
        return answer;
    }
}
