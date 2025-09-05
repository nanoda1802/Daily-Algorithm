namespace Daily_Algorithm._2025_09.day0905;

// [문제 설명] 홀짝에 따라 다른 값 반환하기
// https://school.programmers.co.kr/learn/courses/30/lessons/181935

public class No07
{
    public int Print(int n) {
        bool isEven = n % 2 == 0;
        int start = isEven? 2 : 1;
        int sum = 0;
        
        for (; start <= n; start += 2)
        {
            if (isEven) sum += start*start;
            else sum += start;
        }
        
        return sum;
    }
}

// [다른풀이1 - 등차수열의 합 공식] 