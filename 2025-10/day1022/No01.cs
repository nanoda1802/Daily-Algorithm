namespace Daily_Algorithm._2025_10.day1022;

// [문제 설명] 둘만의 암호
// https://school.programmers.co.kr/learn/courses/30/lessons/155652

public class No01
{
    public string solution(string s, string skip, int index) {  
        List<char> alphabet = Enumerable.Range('a', 'z' - 'a' + 1).Select(x => (char)x).ToList();   
        alphabet.RemoveAll(c=>skip.Contains(c));  
        string answer = "";
      
        for (int i = 0; i < s.Length; i++)  
        {        
            answer += alphabet[(alphabet.IndexOf(s[i]) + index) % alphabet.Count];  
        }    
        return answer;  
    }
}

