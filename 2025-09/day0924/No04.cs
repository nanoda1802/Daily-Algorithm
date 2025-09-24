namespace Daily_Algorithm._2025_09.day0924;

// [문제 설명] 공 던지기
// https://school.programmers.co.kr/learn/courses/30/lessons/120843

public class No04
{
    public int solution(int[] numbers, int k)
    {
        return numbers[((k - 1) * 2) % numbers.Length];
    }
}
