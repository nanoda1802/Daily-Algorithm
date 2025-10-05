namespace Daily_Algorithm._2025_10.day1005;

// [문제 설명] 짝수와 홀수
// https://school.programmers.co.kr/learn/courses/30/lessons/12937

public class No01
{
    public string solution(int num) {
        return num % 2 == 0 ? "Even" : "Odd";
    }
}