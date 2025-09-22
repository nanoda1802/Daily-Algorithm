namespace Daily_Algorithm._2025_09.day0922;

// [문제 설명] 외계행성의 나이
// https://school.programmers.co.kr/learn/courses/30/lessons/120834

public class No02
{
    public string solution(int age)
    {
        string answer = "";
        string s = age + "";
        
        for (int i = 0; i < s.Length; i++)
        {
            answer += (char) (s[i] - 48 + 97);
        }
        
        return answer;
    }
}

// [메모] '0' = 48 / 'a' = 97