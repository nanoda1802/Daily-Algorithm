namespace Daily_Algorithm._2025_10.day1013;

// [문제 설명] 문자열 내 마음대로 정렬하기
// https://school.programmers.co.kr/learn/courses/30/lessons/12915

public class No04
{
    public string[] solution(string[] strings, int n) {
        string[] answer = strings.OrderBy(e => e[n]).ThenBy(e=>e).ToArray();
        return answer;
    }
}

// [다른풀이1 - 아마 출제자의 의도?]
/*
    public string[] solution(string[] strings, int n)
    {
        Array.Sort(strings, (a, b) =>
        {
            int c = a[n].CompareTo(b[n]);
            if (c == 0)
                return a.CompareTo(b);
            return c;
        });
        return strings;
    }
*/