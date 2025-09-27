namespace Daily_Algorithm._2025_09.day0927;

// [문제 설명] 대문자와 소문자
// https://school.programmers.co.kr/learn/courses/30/lessons/120893

public class No03
{
    public string solution(string my_string) {
        // 'A' 65~90
        // 'a' 97~122
        
        string answer = "";

        for (int i = 0; i < my_string.Length; i++)
        {
            char c = my_string[i];
            
            if (c <= 90)
            {
                answer += (char)(c + 32);
            }
            else if (c <= 122)
            {
                answer += (char)(c - 32);
            }
        }
        
        return answer;
    }
}