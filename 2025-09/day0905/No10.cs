namespace Daily_Algorithm._2025_09.day0905;

// [문제 설명] 배열 만들기 1
// https://school.programmers.co.kr/learn/courses/30/lessons/181901

public class No10
{
    public int[] Print(int n, int k) {
        string ks = string.Empty;
        int length = 0;
        
        for (int i = k; i <= n; i += k)
        {
            ks += i + ",";
            length++;
        }
        
        string[] nums = ks.Split(',');
        int[] answer = new int[length];

        for (int i = 0; i < length; i++)
        {
            answer[i] = int.Parse(nums[i]);
        }

        return answer;
    }
}

// [다른풀이1 - Linq]
// return Enumerable.Range(1, n).Where(w => w % k == 0).ToArray();

// [다른풀이2 - List와 Array 변환]
// 이렇겐 풀고 싶지 않았음!!

// [다른풀이3 - 나눗셈 결과가 int면 소수점 이하 버림]
/*
    int[] answer = new int[(int)n/k]; <- 굳이 length를 구할 필요 없었따!
    int i = 1;
    
    while(i * k <= n) <- 배수 표현도 이렇게!
    {
        answer[i-1] = i * k;
        i++;
    }
    
    return answer;
*/