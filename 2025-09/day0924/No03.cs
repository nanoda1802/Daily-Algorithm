namespace Daily_Algorithm._2025_09.day0924;

// [문제 설명] 2차원으로 만들기
// https://school.programmers.co.kr/learn/courses/30/lessons/120842

public class No03
{
    public int[,] solution(int[] num_list, int n)
    {
        int len = num_list.Length / n;
        int idx = 0;
        int[,] answer = new int[len,n];

        
        for (int i = 0; i < len; i++)
        {
            for (int j = 0; j < n; j++)
            {
                answer[i, j] = num_list[idx++];
            }
        }
        
        return answer;
    }
}

// [다른풀이1 - 배수와 나머지] -> [i,0]은 n의 배수 번째 요소, [i,1]부턴 나머지 +1, +2, ...
/*
    int[,] answer = new int[num_list.Length/n,n];
    for(int i = 0; i < num_list.Length; ++i)
    {
        answer[i / n, i % n] = num_list[i];  
    }
    return answer;
*/