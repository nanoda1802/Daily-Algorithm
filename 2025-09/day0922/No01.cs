namespace Daily_Algorithm._2025_09.day0922;

// [문제 설명] 특정문자 제거하기
// https://school.programmers.co.kr/learn/courses/30/lessons/120826

public class No01
{
    public string solution(string my_string, string letter) {
        return my_string.Replace(letter, "");
    }
}