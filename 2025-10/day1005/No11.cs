namespace Daily_Algorithm._2025_10.day1005;

// [문제 설명] 음양 더하기
// https://school.programmers.co.kr/learn/courses/30/lessons/76501

public class No11
{
    public int solution(int[] absolutes, bool[] signs) {
        int answer = 0;

        for (int i = 0; i < absolutes.Length; i++)
        {
            answer += signs[i] ? absolutes[i] : -absolutes[i];
        }
        
        return answer;
    }
}