namespace Daily_Algorithm._2025_09.day0915;

// [문제 설명] 배열의 길이에 따라 다른 연산하기
// https://school.programmers.co.kr/learn/courses/30/lessons/181854

public class No03
{
    public int[] Print(int[] arr, int n) {
        // arr 길이가 홀수 : 짝수 인덱스에 +n
        // arr 길이가 짝수 : 홀수 인덱스에 +n

        int len = arr.Length;
        int start = len % 2 == 0 ? 1 : 0;

        for (int i = start; i < len; i += 2)
        {
            arr[i] += n;
        }

        return arr;
    }
}