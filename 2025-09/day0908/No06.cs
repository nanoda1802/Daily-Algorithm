namespace Daily_Algorithm._2025_09.day0908;

// [문제 설명] 문자열 앞 n글자
// https://school.programmers.co.kr/learn/courses/30/lessons/181907

public class No06
{
    public string Print(string my_string, int n)
    {
        return my_string.Length <= n ? my_string : my_string.Remove(n);
    }
}