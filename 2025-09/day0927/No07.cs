namespace Daily_Algorithm._2025_09.day0927;

// [문제 설명] 약수 구하기
// https://school.programmers.co.kr/learn/courses/30/lessons/120897

public class No07
{
    public int[] solution(int n)
    {
        List<int> answer = new List<int>();

        for (int i = 1; i*i <= n; i++)
        {
            if (n % i == 0)
            {
                answer.Add(i);
                if (i*i != n) answer.Add(n/i);
            }
        }
        
        answer.Sort();
        
        return answer.ToArray();
    }
}