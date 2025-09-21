namespace Daily_Algorithm._2025_09.day0921;

// [문제 설명] 배열의 유사도
// https://school.programmers.co.kr/learn/courses/30/lessons/120903

public class No10
{
    public int solution(string[] s1, string[] s2) {
        int answer = 0;

        foreach (string s in s1)
        {
            if (Array.Exists(s2, e => e == s)) answer += 1;
        }
        
        return answer;
    }
}