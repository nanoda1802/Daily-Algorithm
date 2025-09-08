namespace Daily_Algorithm._2025_09.day0908;

// [문제 설명] 부분문자열 이어붙여 문자열 만들기
// https://school.programmers.co.kr/learn/courses/30/lessons/181911

public class No02
{
    public string Print(string[] my_strings, int[,] parts) {
        string answer = "";

        for (int i = 0; i < my_strings.Length; i++)
        {
            answer += my_strings[i].Substring(parts[i, 0], parts[i, 1] - parts[i, 0]+1);
        }
        
        return answer;
    }
}
