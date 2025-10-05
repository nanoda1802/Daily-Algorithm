namespace Daily_Algorithm._2025_10.day1005;

// [문제 설명] x만큼 간격이 있는 n개 숫자
// https://school.programmers.co.kr/learn/courses/30/lessons/12954

public class No03
{
    public long[] solution(int x, int n) {
        long[] answer = new long[n];
        answer[0] = x;

        for (int i = 1; i < n; i++)
        {
            answer[i] = answer[i - 1] + x;
            //  answer[i] = (long)x * (i + 1); 이게 나았겠다
        }
        
        return answer;
    }
}