namespace Daily_Algorithm._2025_09.day0924;

// [문제 설명] 구슬을 나누는 경우의 수
// https://school.programmers.co.kr/learn/courses/30/lessons/120840

public class No02
{
    public long solution(int balls, int share)
    {
        long result = 1;

        for (int i = 1; i <= share; i++)
        {
            result *= (balls - i + 1);
            result /= i;
        }

        return result;
    }
}

// [메모] 조합 (Combination): n개 중 m개를 순서에 상관없이 선택하는 경우
// n! / m! * (n-m)!