namespace Daily_Algorithm._2025_10.day1025;

// JadenCase 문자열
// https://school.programmers.co.kr/learn/courses/30/lessons/12951

// 공백은 유니코드 몇일까?
// 32라네요~

public class No04
{  
    public string solution(string s)
    {
        string answer = "";

        int dif = 'a' - 'A';
        bool isFirstChar = true;

        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            
            if (isFirstChar && c >= 'a') c = (char)(c - dif);
            if (!isFirstChar && c <= 'Z' && c >= 'A') c = (char)(c + dif);
            
            isFirstChar = c.Equals(' ');
            answer += c;
        }
        
        return answer;
    }
}