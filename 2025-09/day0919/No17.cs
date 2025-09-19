namespace Daily_Algorithm._2025_09.day0919;

// [문제 설명] 자릿수 더하기
// https://school.programmers.co.kr/learn/courses/30/lessons/120906

public class No17
{
    public int solution(int n) {
        int answer = 0;

        char[] arr = (n + "").ToCharArray();

        for (int i = 0; i < arr.Length; i++)
        {
            answer += arr[i] - '0';
        }
        
        return answer;
    }
}
