using System.Text;

namespace Daily_Algorithm._2025_10.day1101;
// 가장 큰 수
// https://school.programmers.co.kr/learn/courses/30/lessons/42746

// 0 또는 양의 정수가 담긴 배열 numbers가 매개변수로 주어질 때,
// 순서를 재배치하여 만들 수 있는 가장 큰 수를 문자열로 바꾸어 return

public class No01
{  
    public string solution(int[] numbers) {
        StringBuilder sb = new StringBuilder();
        
        QuickSort(numbers,0,numbers.Length-1);
        if (numbers[0] == 0) return "0";
        
        foreach (int num in numbers) sb.Append(num);
        return sb.ToString();
    }

    private void QuickSort(int[] arr, int left, int right)
    {
        int curL = left;
        int curR = right;

        string pivot = arr[(left + right) / 2].ToString();

        while (curL <= curR)
        {
            while (Compare(pivot, arr[curL].ToString()) < 0) curL++;
            while (Compare(pivot, arr[curR].ToString()) > 0) curR--;

            if (curL <= curR)
            {
                int temp = arr[curL];
                arr[curL++] = arr[curR];
                arr[curR--] = temp;
            }
        }

        if (left < curR) QuickSort(arr,left,curR);
        if (curL < right) QuickSort(arr,curL,right);
    }

    private int Compare(string a, string b)
    {
        return int.Parse(a + b) - int.Parse(b + a); // 두 숫자를 붙여본 두 경우를 비교하면 됐다...
    }
}

// [메모] 정렬이람서,,, 정렬보다 비교 방법이 훨 중요했던 문제였어,,,
// 왜냐면 그냥 Array.Sort 쓰고 Comparer 람다만 작성해준게 11점이 올랐대...

// [메모] 실패의 흔적
// 6, 23, 500
// 500236
// 650023
        
// 6, 61, 620
// 620, 61, 6
// 662061
// 3 32 333 511 53 5 61 620 6
// 662061553511
        
// 6 61 67
// 67 6 61
        
// 5 51 55 59 510 519 521 528 582 587 593 596
// 596 59 593 587 582 55 5 528 521 519 51 510    
        
// 0번 비교 -> 크거나 작거나면 반환
// 같으면 1번 비교 -> 
        
// 1. 맨앞자리수 기준 오름차순
// 2. 맨앞자리 같으면 다음 자리수 기준 오름차순 반복
// 3. 한자리수는 제일 큰걸로 치기
        
// 짧은 쪽 기준으로 큰 쪽 비교
// 짧은 첫 자리 수와 큰 첫 자리 수 비교 -> 크거나 작거나면 반환
// 같으면 짧은 둘째 자리 수와 큰 