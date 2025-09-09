namespace Daily_Algorithm._2025_09.day0909;

// [문제 설명] n번째 원소부터
// https://school.programmers.co.kr/learn/courses/30/lessons/181892

using System.Linq;

public class No09
{
    public int[] Print(int[] num_list, int n)
    {
        return num_list.Skip(n - 1).ToArray();
    }
}