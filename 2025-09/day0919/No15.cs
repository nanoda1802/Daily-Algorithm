namespace Daily_Algorithm._2025_09.day0919;

// [문제 설명] 세균 증식
// https://school.programmers.co.kr/learn/courses/30/lessons/120810

public class No15
{
    public int solution(int n, int t) {
        // n * 2의 t승
        return n * myPow(2, t);
    }

    private int myPow(int x, int y)
    {
        int result = 1;
        for (int i = 0; i < y; i++)
        {
            result *= x;
        }
        return result;
    }
}

// [다른풀이1 - 비트연산]
// return n << t;