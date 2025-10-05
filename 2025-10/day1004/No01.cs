namespace Daily_Algorithm._2025_10.day1004;

// [문제 설명] 자릿수 더하기
// https://school.programmers.co.kr/learn/courses/30/lessons/12931

public class No01
{
    public int solution(int n) {
        int answer = 0;
        int num = n;

        while (num > 0)
        {
            answer += num % 10;
            num /= 10;
        }        
       
        return answer;
    }
}