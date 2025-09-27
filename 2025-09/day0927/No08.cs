namespace Daily_Algorithm._2025_09.day0927;

// [문제 설명] 최댓값 만들기 2
// https://school.programmers.co.kr/learn/courses/30/lessons/120862

public class No08
{
    public int solution(int[] numbers) {
        Array.Sort(numbers);

        int head = numbers[0] * numbers[1];
        int tail = numbers[-1] * numbers[-2];
        
        return Math.Max(head, tail);
    }
}