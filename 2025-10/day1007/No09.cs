namespace Daily_Algorithm._2025_10.day1007;

// [문제 설명] 크기가 작은 부분문자열
// https://school.programmers.co.kr/learn/courses/30/lessons/147355

public class No09
{
    public int solution(string t, string p) {
        int answer = 0;

        for (int i = 0; i < (t.Length - p.Length + 1); i++)
        {
            if (string.Compare(t.Substring(i,p.Length), p, StringComparison.Ordinal) <= 0)
            {
                answer += 1;
            }
        }
        
        return answer;
    }
}

// [메모] CompareTo는 특정 문화권 전용 비교!
// String.Compare의 마지막 매개변수로 비교 기준을 정해줄 수 있음