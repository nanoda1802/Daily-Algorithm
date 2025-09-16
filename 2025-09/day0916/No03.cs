namespace Daily_Algorithm._2025_09.day0916;

// [문제 설명] 부분 문자열인지 확인하기
// https://school.programmers.co.kr/learn/courses/30/lessons/181843

public class No03
{
    public int Print(string my_string, string target)
    {
        return my_string.Contains(target) ? 1 : 0;
    }
}