namespace Daily_Algorithm._2025_10.day1025;

// 올바른 괄호
// https://school.programmers.co.kr/learn/courses/30/lessons/12909

// 연속된 '('의 개수와 연속된 ')'의 개수가 같은지?

public class No02 
{  
    public bool solution(string s) {
        // '('로 시작했다면 개수만 같으면 무조건 성립하는 거 같은데?
        // 아닌가배 반례가 머징?
        
        int cnt = 0;
        foreach (char c in s)
        {
            if (c.Equals('(')) cnt++;
            else cnt--;

            if (cnt < 0) return false;  
        }

        return cnt == 0;
    }
}

// [메모] 지금 봤는데 스택/큐로 해결하는 문제였나봐...