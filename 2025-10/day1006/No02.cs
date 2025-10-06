namespace Daily_Algorithm._2025_10.day1006;

// [문제 설명] 서울에서 김서방 찾기
// https://school.programmers.co.kr/learn/courses/30/lessons/12919

public class No02
{
    public string solution(string[] seoul)
    {
        int answer = Array.IndexOf(seoul, "Kim");
        return $"김서방은 {answer}에 있다";
    }
}