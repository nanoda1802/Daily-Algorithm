namespace Daily_Algorithm._2025_09.day0904;

// [문제 설명] 대소문자 바꿔서 출력하기
// 영어 알파벳으로 이루어진 문자열 str이 주어집니다. 각 알파벳을 대문자는 소문자로 소문자는 대문자로 변환해서 출력하는 코드를 작성해 보세요.
// https://school.programmers.co.kr/learn/courses/30/lessons/181949

public class No06
{
    public void Print()
    {
        String s;
        String answer = "";
        
        Console.Clear();
        s = Console.ReadLine();
        
        foreach (char c in s) 
        {
            answer += char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c);
        }
        
        Console.WriteLine(answer);
    }
}

// [다른 풀이] ASCII 코드 활용 대소문자 구분+변환