namespace Daily_Algorithm._2025_09.day0904;

// [문제 설명] 문자열 돌리기
// https://school.programmers.co.kr/learn/courses/30/lessons/181945


public class No10
{
    public void Print()
    {
        String s;
        String answer = String.Empty;
        
        Console.Clear();
        s = Console.ReadLine();

        foreach (char c in s)
        {
            answer += c + "\n";
        }

        Console.WriteLine(answer);
    }
}