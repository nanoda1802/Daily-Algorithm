namespace Daily_Algorithm._2025_09.day0905;

// [문제 설명] 두 수의 연산값 비교하기
// https://school.programmers.co.kr/learn/courses/30/lessons/181938

public class No05
{
    public int Print(int a, int b)
    {
        int n = int.Parse(a + "" + b);
        int m = 2 * a * b;
        
        return n >= m ? n : m;
    }
}
