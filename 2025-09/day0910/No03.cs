namespace Daily_Algorithm._2025_09.day0910;

// [문제 설명] n번째 원소까지
// https://school.programmers.co.kr/learn/courses/30/lessons/181889

public class No03
{
    public int[] Print(int[] num_list, int n)
    {
        int[] answer = new int[n];

        for (int i = 0; i < n; i++)
        {
            answer[i] = num_list[i];
        }

        return answer;
    }
}

// [다른풀이1 - Linq]
// answer = num_list.Take(n).ToArray();