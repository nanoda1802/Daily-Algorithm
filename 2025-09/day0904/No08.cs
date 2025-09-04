namespace Daily_Algorithm._2025_09.day0904;

// [문제 설명] 덧셈식 출력하기
// 두 정수 a, b가 주어질 때 다음과 같은 형태의 계산식을 출력하는 코드를 작성해 보세요. a + b = c
// https://school.programmers.co.kr/learn/courses/30/lessons/181947


public class No08
{
    public void Print()
    {
        String[] s;

        Console.Clear();
        s = Console.ReadLine().Split(' ');

        int a = Int32.Parse(s[0]);
        int b = Int32.Parse(s[1]);

        Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
    }
}