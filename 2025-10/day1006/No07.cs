namespace Daily_Algorithm._2025_10.day1006;

// [문제 설명] 내적
// https://school.programmers.co.kr/learn/courses/30/lessons/70128

public class No07
{
    public int solution(int[] a, int[] b) {
        int answer = 0;

        for (int i = 0; i < a.Length; i++)
        {
            answer += a[i] * b[i];
        }
        
        return answer;
    }
}