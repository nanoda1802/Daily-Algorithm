namespace Daily_Algorithm._2025_10.day1007;

// [문제 설명] 문자열 내림차순 배치
// https://school.programmers.co.kr/learn/courses/30/lessons/12917

public class No03
{
    public string solution(string s) {
        char[] cs = s.ToCharArray();
        Array.Sort(cs,(e1,e2)=> e2-e1);

        return new string(cs);
    }
}