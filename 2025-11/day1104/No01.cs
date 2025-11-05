namespace Daily_Algorithm._2025_11.day1104;
// 모음사전
// https://school.programmers.co.kr/learn/courses/30/lessons/84512
public class No01
{  
    public int solution(string word) {  
        int answer = 0;  
        DFS(new[] {'A','E','I','O','U'},word,"",ref answer);  
        return answer;  
    }  
  
    private bool DFS(char[] vowels, string target, string str, ref int count)  
    {  
        if (str.Equals(target)) return true;  
        foreach (char c in vowels)  
        {        
            if (str.Length < 5)  
            {            
                count++;            
                bool found = DFS(vowels, target, str+c, ref count);  
                if (found) return true;  
            }    
        }    
        return false;  
    }
}