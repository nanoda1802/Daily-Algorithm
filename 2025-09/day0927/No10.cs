namespace Daily_Algorithm._2025_09.day0927;

// [문제 설명] A로 B 만들기
// https://school.programmers.co.kr/learn/courses/30/lessons/120886

public class No10
{
    public int solution(string before, string after) {
        char[] b = before.ToCharArray();
        Array.Sort(b);
        char[] a = after.ToCharArray();
        Array.Sort(a);

        for (int i = 0; i < b.Length; i++)
        {
            if (b[i] != a[i]) return 0;
        }

        string.Concat(b==a);
        
        return 1;
    }
}