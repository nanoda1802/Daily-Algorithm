namespace Daily_Algorithm._2025_10.day1001;

// [문제 설명] 겹치는 선분의 길이
// https://school.programmers.co.kr/learn/courses/30/lessons/120876

public class No02
{
    public int solution(int[,] lines)
    {
        int[] graph = new int[201];

        for (int i = 0; i < lines.GetLength(0); i++)
        {
            int start = lines[i, 0] + 100;
            int end = lines[i, 1] + 100;

            graph[start] += 1;
            graph[end] -= 1;
        }

        for (int i = 1; i < graph.Length; i++)
        {
            graph[i] = graph[i - 1] + graph[i];
        } // -> 여기가 이해 안 됨
        
        int answer = 0;
        
        for (int i = 0; i < graph.Length; i++)
        {
            if (graph[i] > 1) answer += 1;
        }
        
        return answer;
     
        
        // int[] graph = new int[200];
        //
        // for (int i = 0; i < lines.GetLength(0); i++)
        // {
        //     int start = lines[i, 0] + 100;
        //     int end = lines[i, 1] + 100;
        //
        //     for (int j = start; j < end; j++)
        //     {
        //         graph[j] += 1;
        //     }
        // }
        //
        // int answer = 0;
        //
        // for (int i = 0; i < graph.Length - 1; i++)
        // {
        //     if (graph[i] > 1) answer += 1;
        // }
        //
        // return answer;
    }
}

// [메모] IMOS 알고리즘...!
// https://00ad-8e71-00ff-055d.tistory.com/215
// https://yobi-devlog.tistory.com/entry/%EC%95%8C%EA%B3%A0%EB%A6%AC%EC%A6%98-%EC%9D%B4%EB%AA%A8%EC%8A%A4%EB%B2%95-Imos-Method
// https://bbooo.tistory.com/169
// https://nicotina04.tistory.com/163
