namespace Daily_Algorithm._2025_10.day1008;

// [문제 설명] 3총사
// https://school.programmers.co.kr/learn/courses/30/lessons/131705

public class No03
{
    public int solution(int[] number)
    {
        Array.Sort(number);

        if (number[0] >= 0 || number[number.Length-1] <= 0)
        {
            return 0;
        }

        int answer = 0;
        
        for (int i = 0; i < number.Length-2; i++)
        {
            for (int j = i+1; j < number.Length-1; j++)
            {
                for (int k = j+1; k < number.Length; k++)
                {
                    if (number[i] + number[j] + number[k] == 0) answer += 1;
                }
                
            }
        }
        
        return answer;
    }
}

// [메모] DFS가 가능한 문제인가 보다! 깊이우선탐색! DFS는 "모든 노드"를 확인해야할 때 사용!
/*
    using System.Collections.Generic;
    using System.Linq;
    
    public class Solution
    {
        private List<int> answer;
        private int[] number;
        
        public int solution(int[] number)
        {
            answer = new List<int>();
            this.number = number;
    
            DFS(0, new bool[number.Length], 0);
    
            return answer.Where(x => x == 0).Count();
        }
    
        private void DFS(int depth, bool[] depthCount, int start)
        {
            if (depth == 3)
            {
                int sum = 0;
                for (int i = 0; i < depthCount.Length; i++)
                {
                    if (depthCount[i])
                    {
                        sum += number[i];
                    }
                }
                answer.Add(sum);
            }
    
            for (int i = start; i < depthCount.Length; i++)
            {
                if (!depthCount[i])
                {
                    depthCount[i] = true;
                    DFS(depth + 1, depthCount, i);
                    depthCount[i] = false;
                }
            }
        }
    }
*/