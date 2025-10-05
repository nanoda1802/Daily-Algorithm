namespace Daily_Algorithm._2025_10.day1005;

// [문제 설명] 나머지가 1이 되는 수 찾기
// https://school.programmers.co.kr/learn/courses/30/lessons/87389

public class No04
{
    public int solution(int n) {
        int answer = 0;

        for (int i = 2; i < n; i++)
        {
            if ((n - 1) % i == 0)
            {
                answer = i;
                break;
            }
        }
        
        return answer;
    }
}