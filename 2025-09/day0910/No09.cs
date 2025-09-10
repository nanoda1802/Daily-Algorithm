namespace Daily_Algorithm._2025_09.day0910;

// [문제 설명] 수열과 구간 쿼리 1
// https://school.programmers.co.kr/learn/courses/30/lessons/181883

public class No09
{
    public int[] Print(int[] arr, int[,] queries) {
        // s~e 사이의 i에 해당하는 모든 arr[i]에 + 1
        int[] answer = arr;
        
        for (int i = 0; i < queries.GetLength(0); i++)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                answer[j] = j >= queries[i,0] && j <= queries[i,1] ? answer[j] + 1 : answer[j];
            }
        }
        
        return answer;
    }
}