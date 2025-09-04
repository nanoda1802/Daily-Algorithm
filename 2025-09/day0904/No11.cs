namespace Daily_Algorithm._2025_09.day0904;

// [문제 설명] 홀짝 구분하기
// https://school.programmers.co.kr/learn/courses/30/lessons/181944


public class No11
{
    public void Print()
    {
        String[] s;

        Console.Clear();
        s = Console.ReadLine().Split(' ');

        int a = Int32.Parse(s[0]);

        String answer = a % 2 == 0 ? string.Format("{0} is even", a) : string.Format("{0} is odd", a);
        Console.WriteLine(answer);
    }
}