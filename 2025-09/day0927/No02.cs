namespace Daily_Algorithm._2025_09.day0927;

// [문제 설명] 암호 해독
// https://school.programmers.co.kr/learn/courses/30/lessons/120892

public class No02
{
    public string solution(string cipher, int code) {
        string answer = "";

        for (int i = code-1; i < cipher.Length; i += code)
        {
            answer += cipher[i];
        }
        
        return answer;
    }
}