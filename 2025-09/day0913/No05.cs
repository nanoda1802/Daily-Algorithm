namespace Daily_Algorithm._2025_09.day0913;

// [문제 설명] 문자열 잘라서 정렬
// https://school.programmers.co.kr/learn/courses/30/lessons/181866

public class No05
{
    public string[] Print(string myString)
    {
        string[] answer = myString.Split('x', StringSplitOptions.RemoveEmptyEntries);
        
        Array.Sort(answer);
        
        return answer;
    }
}