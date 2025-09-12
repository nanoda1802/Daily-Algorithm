namespace Daily_Algorithm._2025_09.day0912;

// [문제 설명] A 강조하기
// https://school.programmers.co.kr/learn/courses/30/lessons/181874

public class No04
{
    public string Print(string myString) {
        // 'A' 65~90
        // 'a' 97~122
        // 'a' -> 'A'
        // 'A' 제외 대문자 -> 소문자
        
        string answer = "";

        for (int i = 0; i < myString.Length; i++)
        {
            char c  = myString[i];
            
            if (c.Equals('a')) answer += (char) (c - 32);
            else if (c > 65 && c <= 90) answer += (char)(c + 32);
            else answer += c;
        }
        
        return answer;
    }
}

// [다른풀이1 - 문제해독] <- 다 소문자 만들고 a만 A로 바꾸면 같은 결과!
// return myString.ToLower().Replace('a', 'A'); 