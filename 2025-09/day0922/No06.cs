namespace Daily_Algorithm._2025_09.day0922;

// [문제 설명] 중복 숫자 개수
// https://school.programmers.co.kr/learn/courses/30/lessons/120583

public class No06
{
    public int solution(int[] array, int n)
    {
        return array.Count(e => e == n);
    }
}