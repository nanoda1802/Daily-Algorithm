namespace Daily_Algorithm._2025_10.day1008;

// [문제 설명] 예산
// https://school.programmers.co.kr/learn/courses/30/lessons/12982

public class No01
{
    public int solution(int[] d, int budget)
    {
        int sum = 0;
        int answer = 0;
        
        Array.Sort(d);

        foreach (int i in d)
        {
            if (budget < sum + i)
            {
                break;
            }

            sum += i;
            answer += 1;
        }
        
        return answer;
    }
}