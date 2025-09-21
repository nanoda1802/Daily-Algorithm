namespace Daily_Algorithm._2025_09.day0921;

// [문제 설명] 머쓱이보다 키 큰 사람
// https://school.programmers.co.kr/learn/courses/30/lessons/120585

public class No07
{
    public int solution(int[] array, int height)
    {
        return array.Count(e => e > height);
    }
}