namespace Daily_Algorithm._2025_09.day0904;

// [문제 설명] a와 b 출력하기
// 정수 a와 b가 주어집니다. 각 수를 입력받아 입출력 예와 같은 형식으로 출력하는 코드를 작성해 보세요.
// https://school.programmers.co.kr/learn/courses/30/lessons/181951

public class No04
{
    public void Print()
    {
        String[] s;

        Console.Clear();
        s = Console.ReadLine().Split(' ');

        int a = Int32.Parse(s[0]);
        int b = Int32.Parse(s[1]);

        Console.WriteLine("a = {0}\nb = {1}", a, b);
    }
}