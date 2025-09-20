namespace Daily_Algorithm._2025_09.day0920;

// [문제 설명] 짝수의 합
// https://school.programmers.co.kr/learn/courses/30/lessons/120831

public class No07
{
    public  int solution(int n)
    {
        return Enumerable.Range(1, n).Where(i => i % 2 == 0).Sum();
    }
}

// [다른 풀이]
// return n/2*(n/2+1);