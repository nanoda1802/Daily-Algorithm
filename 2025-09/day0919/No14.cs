namespace Daily_Algorithm._2025_09.day0919;

// [문제 설명] 뒤집힌 문자열
// https://school.programmers.co.kr/learn/courses/30/lessons/120822

using System.Text;

public class No14
{
    public string solution(string my_string)
    {
        StringBuilder sb = new StringBuilder();

        for (int i = my_string.Length-1; i >= 0; i--)
        {
            sb.Append(my_string[i]);
        }

        return sb.ToString();
    }
}
