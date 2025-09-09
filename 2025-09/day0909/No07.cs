namespace Daily_Algorithm._2025_09.day0909;

// [문제 설명] 2의 영역
// https://school.programmers.co.kr/learn/courses/30/lessons/181894

public class No07
{
    public int[] Print(int[] arr) {
        int start = Array.FindIndex(arr, e => e == 2);
        if (start == -1) return new int[] {-1};
        
        Array.Reverse(arr);
        int end = arr.Length - 1 - Array.FindIndex(arr, e => e == 2);
        Array.Reverse(arr);
            
        if (start == end) return new int[] {2};
 
        int[] answer = new int[end - start + 1];

        for (int i = start; i <= end; i++)
        {
            answer[i - start] = arr[i];
        }

        return answer;
    }
}

// [다른풀이1 - Array 메서드] <- 내가 하고 싶었던 거...
/*
    int start = Array.IndexOf(arr, 2);
    if(start == -1) return new int[1]{ -1 };

    int end = Array.LastIndexOf(arr, 2);

    int[] answer = new int[end - start + 1];
    Array.Copy(arr, start, answer, 0, answer.Length);
    return answer;
*/