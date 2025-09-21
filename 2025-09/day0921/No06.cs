namespace Daily_Algorithm._2025_09.day0921;

// [문제 설명] 최대값 만들기 1
// https://school.programmers.co.kr/learn/courses/30/lessons/120847

public class No06
{
    public int solution(int[] numbers) {
        // 제일 큰 수 두 개를 뽑기?
        
        Array.Sort(numbers);
        return numbers[numbers.Length - 1] * numbers[numbers.Length - 2];
    }
}