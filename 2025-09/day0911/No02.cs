namespace Daily_Algorithm._2025_09.day0911;

// [문제 설명] 조건에 맞게 수열 변환 2
// https://school.programmers.co.kr/learn/courses/30/lessons/181881

public class No02
{
    public int Print(int[] arr, int tryCount = 0) {
        // 50 이상 짝수면 나누기 2
        // 50 미만 홀수면 곱하기 2 더하기 1
        // 50 미만은 짝수 뿐이고, 50 이상은 홀수 뿐이 되는 첫 시행횟수 구하기

        int[] temp = arr;
        int n = 0;
        int equalCount = 0;
        
        for (int i = 0; i < temp.Length; i++)
        {
            n = temp[i];
            if (n>=50 && n % 2==0) temp[i] = n / 2;
            else if (n < 50 && n % 2 != 0) temp[i] = n * 2 + 1;
            else equalCount += 1;
        }
        
        if (equalCount == temp.Length) return tryCount; 
        return Print(temp, tryCount + 1);
    }
}

// [메모] 왜 나만 while문 시간 초과...?