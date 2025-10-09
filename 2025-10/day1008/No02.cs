namespace Daily_Algorithm._2025_10.day1008;

// [문제 설명] 3진법 뒤집기
// https://school.programmers.co.kr/learn/courses/30/lessons/68935

public class No02
{
    public int solution(int n) {
        int answer = 0;

        string str = "";

        int num = n;

        while (num>0)
        {
            str += num % 3;
            num /= 3;
        }

        int three = 1;
        
        for (int i = 0; i < str.Length; i++)
        {
            answer += three * (str[str.Length - 1 - i] - '0');
            three *= 3;
        }
        
        return answer;
    }
}

// [메모] 10진수 x를 n진수로 바꾸는 방법
// 1. x를 n으로 나눈다.
// 2. 그 나머지가 n진수의 맨 앞 수
// 3. 몫을 n으로 나눈다.
// 4. 그 나머지가 n진수의 그 다음 수
// 5. 몫이 0이 되는 경우까지 반복한다. (이때의 나머지도 추가해야 함)
// 6. 나머지들을 앞 회차부터 이어붙이면 n진수 완성!