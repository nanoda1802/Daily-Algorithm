namespace Daily_Algorithm._2025_09.day0909;

// [문제 설명] 가까운 1 찾기
// https://school.programmers.co.kr/learn/courses/30/lessons/181898

public class No03
{
    public int Print(int[] arr, int idx) {
        int answer = -1;

        for (int i = idx; i < arr.Length; i++)
        {
            if (arr[i] == 1)
            {
                answer = i;
                break;
            }
        }

        return answer;
    }
}

// [다른풀이1 - Array 메서드]
// Array.FindIndex(arr, idx, arr.Length-idx, index => index == 1);
// 배열, 시작인덱스, 찾을길이, Predicate