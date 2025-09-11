namespace Daily_Algorithm._2025_09.day0911;

// [문제 설명] 조건에 맞게 수열 변환 1
// https://school.programmers.co.kr/learn/courses/30/lessons/181882

public class No01
{
    public int[] Print(int[] arr) {
        // 50 이상 짝수면 나누기 2
        // 50 미만 홀수면 곱하기 2
        
        int[] answer = new int[arr.Length];
        int n = 0;
        
        for (int i = 0; i < arr.Length; i++)
        {
            n = arr[i];
            
            if (n >= 50 && n % 2 == 0) answer[i] = n / 2;
            else if (n < 50 && n % 2 != 0) answer[i] = n * 2;
            else answer[i] = n;
        }
        
        return answer;
    }
}