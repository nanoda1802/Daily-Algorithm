namespace Daily_Algorithm._2025_10.day1007;

// [문제 설명] 문자열 다루기 기본
// https://school.programmers.co.kr/learn/courses/30/lessons/12918

public class No05
{
    public bool solution(string s) {
        // '0' = 48, '9' = 57

        if (!(s.Length == 4 || s.Length == 6)) return false;

        foreach (char c in s)
        {
            if (c < 48 || c > 57) return false;
        }
        
        return true;
    }
}

// [다른 풀이1 - TryParse]
// answer = int.TryParse(s, out int i);