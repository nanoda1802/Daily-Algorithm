namespace Daily_Algorithm._2025_10.day1006;

// [문제 설명] 가운데 글자 가져오기
// https://school.programmers.co.kr/learn/courses/30/lessons/12903

public class No05
{
    public string solution(string s) {
        return s.Length%2==0? s.Substring(s.Length/2-1,2) : s.Substring(s.Length/2,1);
    }
}

// [다른풀이 - 조건문 대신 수식으로]
/*
    int n = (s.Length + 1) % 2;
    int l = s.Length / 2 - n;
    return s.Substring(l, n + 1);
*/