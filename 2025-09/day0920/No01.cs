namespace Daily_Algorithm._2025_09.day0920;

// [문제 설명] 중앙값 구하기
// https://school.programmers.co.kr/learn/courses/30/lessons/120811

public class No01
{
    public int solution(int[] array)
    {
        Array.Sort(array);
        return array[array.Length / 2];
    }
}