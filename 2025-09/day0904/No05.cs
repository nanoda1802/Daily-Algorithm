namespace Daily_Algorithm._2025_09.day0904;

// [문제 설명] 문자열 반복해서 출력하기
// 문자열 str과 정수 n이 주어집니다. str이 n번 반복된 문자열을 만들어 출력하는 코드를 작성해 보세요.
// https://school.programmers.co.kr/learn/courses/30/lessons/181950

public class No05
{
    public void Print()
    {
        String[] input;

        Console.Clear();
        input = Console.ReadLine().Split(' ');

        String s1 = input[0];
        int a = Int32.Parse(input[1]);

        Console.WriteLine(String.Concat(Enumerable.Repeat(s1,a)));
    }
}

// [다른 풀이] StringBuilder 사용