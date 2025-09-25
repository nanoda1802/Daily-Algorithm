namespace Daily_Algorithm._2025_09.day0925;

// [문제 설명] 숨어있는 숫자의 덧셈 1
// https://school.programmers.co.kr/learn/courses/30/lessons/120851

public class No05
{
    public int solution(string my_string) {
        int answer = 0;

        foreach (char c in my_string)
        {
            if (Char.IsDigit(c)) answer += c - '0';
        }
        
        return answer;
    }
}

// [다른풀이1 - Char.IsNumber] 
//  if (Char.IsNumber(c)) answer += c - '0';
