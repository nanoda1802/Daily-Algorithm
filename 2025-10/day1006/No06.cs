namespace Daily_Algorithm._2025_10.day1006;

// [문제 설명] 제일 작은 수 제거하기
// https://school.programmers.co.kr/learn/courses/30/lessons/12935

public class No06
{
    public int[] solution(int[] arr)
    {
        if (arr.Length <= 1) return new int[] { -1 };

        int min = Int32.MaxValue;

        foreach (int i in arr)
        {
            if (min > i) min = i;
        }

        return Array.FindAll(arr, e => e != min);
    }
}