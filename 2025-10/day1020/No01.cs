namespace Daily_Algorithm._2025_10.day1020;

// [문제 설명] 문자열 나누기
// https://school.programmers.co.kr/learn/courses/30/lessons/140108

public class No01
{
    public int solution(string s)
    {
        char curX = s[0];
        int xCount = 1;
        int answer = 1;
        
        for (int i = 1; i < s.Length; i++)
        {
            if (xCount <= 0)
            {
                curX = s[i];
                xCount = 1;
                answer++;
                continue;
            }

            xCount += (curX == s[i]) ? 1 : -1; 
        }
        
        return answer;
    }
}

