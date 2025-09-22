namespace Daily_Algorithm._2025_09.day0922;

// [문제 설명] 문자열 안 문자열
// https://school.programmers.co.kr/learn/courses/30/lessons/120908

public class No04
{
    public int solution(string str1, string str2) {
        return str1.Contains(str2) ? 1 : 2;
    }
}