namespace Daily_Algorithm._2025_09.day0909;

// [문제 설명] 배열 만들기 3
// https://school.programmers.co.kr/learn/courses/30/lessons/181895

public class No06
{
    public int[] Print(int[] arr, int[,] intervals) {
        List<int> answer = new List<int>();

        for (int i = 0; i < intervals.GetLength(0); i++)
        {
            int start = intervals[i, 0];
            int end = intervals[i, 1];

            for (int j = start; j <= end; j++)
            {
                answer.Add(arr[j]);
            }
        }

        return answer.ToArray();
    }
}

// [메모] 문제를 잘 읽자... intervals는 무조건 2개 요소만이네...

// [다른풀이1 - Array 메서드]
/*
    int size1 = intervals[0, 1] - intervals[0, 0] + 1;
    int size2 = intervals[1, 1] - intervals[1, 0] + 1;
    
    int[] answer = new int[size1 + size2];
    Array.Copy(arr, intervals[0, 0], answer, 0, size1);
    Array.Copy(arr, intervals[1, 0], answer, size1, size2);
    
    return answer;
*/