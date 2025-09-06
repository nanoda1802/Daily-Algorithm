namespace Daily_Algorithm._2025_09.day0906;

// [문제 설명] 수열과 구간 쿼리 2
// https://school.programmers.co.kr/learn/courses/30/lessons/181923

public class No10
{
    public int[] Print(int[] arr, int[,] queries)
    {
        int queriesLength = queries.GetLength(0);
        int[] answer = new int[queriesLength];

        int s = 0;
        int e = 0;
        int k = 0;

        for (int n = 0; n < queriesLength; n++)
        {
            s = queries[n, 0];
            e = queries[n, 1];
            k = queries[n, 2];

            answer[n] = -1;
            
            for (; s <= e; s++)
            {
                if (arr[s] > k && (answer[n] == -1 || answer[n] > arr[s]))
                {
                    answer[n] = arr[s];
                }
            }
        }
        
        return answer;
    }
}

// [다른풀이1 - Linq]
// answer[n] = arr.Skip(s).Take(e - s + 1).Where(w => w > k).DefaultIfEmpty(-1).OrderBy(o => o).First();

// [시도 1 - Linq] -> 문제 잘 못 읽음, 문제의 i는 index인디 element로 풀이
// answer[n] = arr.Where(i => (i >= s) && (i <= e)).FirstOrDefault(i => (i > k), -1);

// [시도 2 - Array 메서드] -> System.OutOfMemoryException
// int[] targetArr = new int[s-e];
// Array.Copy(arr,s,targetArr,e,e-s);
// Array.Sort(targetArr);
// int? target = Array.Find(targetArr,i => i > k);
// answer[n] = target.HasValue ? target.Value : -1;