namespace Daily_Algorithm._2025_09.day0914;

// [문제 설명] 배열 비교하기
// https://school.programmers.co.kr/learn/courses/30/lessons/181856

public class No05
{
    public int Print(int[] arr1, int[] arr2)
    {
        int len1 = arr1.Length;
        int len2 = arr2.Length;

        if (len1 != len2) return len1 > len2 ? 1 : -1;

        int cnt1 = Sum(arr1);
        int cnt2 = Sum(arr2);

        if (cnt1 == cnt2) return 0;

        return cnt1 > cnt2 ? 1 : -1;
    }

    private int Sum(int[] arr)
    {
        int cnt = 0;
        
        for (int i = 0; i < arr.Length; i++)
        {
            cnt += arr[i];
        }

        return cnt;
    }
}