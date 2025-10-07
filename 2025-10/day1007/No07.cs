namespace Daily_Algorithm._2025_10.day1007;

// [문제 설명] 직사각형 별 찍기
// https://school.programmers.co.kr/learn/courses/30/lessons/12969

public class No07
{
    public void solution()
    {
        String[] s;

        Console.Clear();
        s = Console.ReadLine().Split(' ');

        int a = Int32.Parse(s[0]);
        int b = Int32.Parse(s[1]);

        for (int i = 0; i < b; i++)
        {
            for (int j = 0; j < a; j++)
            {
                Console.Write('*');
            }
            Console.Write("\n");
        }
    }
}