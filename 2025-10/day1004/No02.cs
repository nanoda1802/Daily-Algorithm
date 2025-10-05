namespace Daily_Algorithm._2025_10.day1004;

// [문제 설명] 자연수 뒤집어 배열로 만들기
// https://school.programmers.co.kr/learn/courses/30/lessons/12931

public class No02
{
    public int[] solution(long n) {
        int[] answer = new int[(int)Math.Floor(Math.Log10(n) + 1)];

        long num = n;
       
        for (int i = 0; i < answer.Length; i++)
        {
            answer[i] = (int) (num % 10);
            num /= 10;
        }
       
        return answer;
    }
}

// [메모] 문자열 사용하지 않고 정수의 길이 알아내는 법
// https://alpaca-code.tistory.com/21