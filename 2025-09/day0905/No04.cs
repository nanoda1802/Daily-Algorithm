namespace Daily_Algorithm._2025_09.day0905;

// [문제 설명] 더 크게 합치기
// https://school.programmers.co.kr/learn/courses/30/lessons/181939

public class No04
{
    public int Print(int a, int b)
    {
        int n = int.Parse(a + "" + b);
        int m = int.Parse(b + "" + a);
        
        return n >= m ? n : m;
    }
}

// [다른풀이1 - 비교연산 대신 최대값]
// return Math.Max(n,m)