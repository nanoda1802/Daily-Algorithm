namespace Daily_Algorithm._2025_09.day0912;

// [문제 설명] 대문자로 바꾸기
// https://school.programmers.co.kr/learn/courses/30/lessons/181877

public class No01
{
    public string Print(string myString) {
        // 'A' 65~90
        // 'a' 97~122
        // 32 빼기
        
        string answer = "";

        for (int i = 0; i < myString.Length; i++)
        {
            char c = myString[i];
            int code = c >= 65 && c <= 90 ? c : c - 32;
            answer += (char) code;
        }
        
        return answer;
    }
}