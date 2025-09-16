namespace Daily_Algorithm._2025_09.day0916;

// [문제 설명] 부분 문자열
// https://school.programmers.co.kr/learn/courses/30/lessons/181842

public class No04
{
    public int Print(string str1, string str2)
    {
        return str2.Contains(str1) ? 1 : 0;
    }
}