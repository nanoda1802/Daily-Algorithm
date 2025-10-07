namespace Daily_Algorithm._2025_10.day1007;

// [문제 설명] 수박수박수박수박수박수?
// https://school.programmers.co.kr/learn/courses/30/lessons/12922

using System.Text;

public class No01
{
    public string solution(int n)
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < n; i++)
        {
            sb.Append(i%2==0?"수":"박");
        }

        return sb.ToString();
    }
}