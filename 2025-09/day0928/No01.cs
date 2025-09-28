namespace Daily_Algorithm._2025_09.day0928;

// [문제 설명] 문자열 계산하기
// https://school.programmers.co.kr/learn/courses/30/lessons/120902

public class No01
{
    public int solution(string my_string)
    {
        string[] arr = my_string.Split(" ");
        int answer = int.Parse(arr[0]);

        for (int i = 1; i < arr.Length; i += 2)
        {
            if (arr[i].Equals("+")) answer += int.Parse(arr[i + 1]);
            else if (arr[i].Equals("-")) answer -= int.Parse(arr[i + 1]);
        }
        
        return answer;
    }
}
