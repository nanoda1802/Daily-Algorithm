namespace Daily_Algorithm._2025_09.day0916;

// [문제 설명] 주사위 게임 1
// https://school.programmers.co.kr/learn/courses/30/lessons/181839

public class No05
{
    public int Print(int a, int b) {
        int answer = 0;
        
        if (IsEven(a) && IsEven(b)) answer = a < b ? b - a : a - b;
        else if (!IsEven(a) && !IsEven(b)) answer = a * a + b * b;
        else answer = 2 * (a + b);
        
        return answer;
    }

    private bool IsEven(int a)
    {
        return a % 2 == 0;
    }
}