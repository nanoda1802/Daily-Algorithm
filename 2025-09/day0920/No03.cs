namespace Daily_Algorithm._2025_09.day0920;

// [문제 설명] 짝수는 싫어요
// https://school.programmers.co.kr/learn/courses/30/lessons/120813

public class No03
{
    public int[] solution(int n)
    {
        int len = n % 2 == 0 ? n/2 : n/2+1;
        int[] answer = new int[len];
        int idx = 0;
        
        for (int i = 1; i <= n; i += 2)
        {
            answer[idx++] = i;
        }
        
        return answer;
    }
}