namespace Daily_Algorithm._2025_10.day1013;

// [문제 설명] 콜라 문제
// https://school.programmers.co.kr/learn/courses/30/lessons/132267

public class No03
{
    public int solution(int a, int b, int n) {
        // a병을 주면 b병을 새로 주는 마트, n병을 가져간다면?
        
        // 첫 교환 : x1 = (n / a) * b
        // 첫 남은 병 : y1 = n % a + x1
        
        // 다음 교환 : x2 = (y1 / a) * b
        // 다음 남은 병 : y2 = y1 % a + x2

        int answer = 0;
        int cnt;
        
        while (n >= a)
        {
            cnt = (n / a) * b;
            n = n % a + cnt;
            answer += cnt;
        }
        
        return answer;
    }
}

// [다른풀이1 - 이거 원리가 뭐지]
/*
    public int solution(int a, int b, int n) {
        return (n > b ? n - b : 0) / (a - b) * b;
    }
*/