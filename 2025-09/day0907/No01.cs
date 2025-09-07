namespace Daily_Algorithm._2025_09.day0907;

// [문제 설명] 수열과 구간 쿼리 4
// https://school.programmers.co.kr/learn/courses/30/lessons/181922

public class No01
{
    public int[] Print(int[] arr, int[,] queries) {
        int[] answer = new int[arr.Length];
        Array.Copy(arr, answer, arr.Length);

        int s = 0;
        int e = 0;
        int k = 0;

        for (int n = 0; n < queries.GetLength(0); n++)
        {
            s = queries[n, 0];
            e = queries[n, 1];
            k = queries[n, 2];

            for (int i = s; i <= e; i++)
            {
                if (i % k == 0)
                {
                    answer[i] += 1;
                }
            }
        }
        
        return answer;
    }
}
