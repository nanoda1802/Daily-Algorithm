namespace Daily_Algorithm._2025_09.day0921;

// [문제 설명] 배열 원소의 길이
// https://school.programmers.co.kr/learn/courses/30/lessons/120854

public class No14
{
    public int[] solution(string[] strlist)
    {
        return strlist.Select(e => e.Length).ToArray();
    }
}