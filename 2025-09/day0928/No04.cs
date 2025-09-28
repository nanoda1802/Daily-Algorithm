namespace Daily_Algorithm._2025_09.day0928;

// [문제 설명] 문자열 정렬하기 2
// https://school.programmers.co.kr/learn/courses/30/lessons/120911

public class No04
{
    public string solution(string my_string) {
        return new string( my_string.ToLower().OrderBy(c => c).ToArray());    }
}
