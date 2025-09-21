namespace Daily_Algorithm._2025_09.day0921;

// [문제 설명] 배열 자르기
// https://school.programmers.co.kr/learn/courses/30/lessons/120833

public class No09
{
    public int[] solution(int[] numbers, int num1, int num2)
    {
        int[] answer = new int[num2-num1+1];
        int idx = 0;
        
        for (int i = num1; i <= num2; i++)
        {
            answer[idx++] = numbers[i];
        }
        
        return answer;
    }
}