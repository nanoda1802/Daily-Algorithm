namespace Daily_Algorithm._2025_10.day1022;

// [문제 설명] 성격 유형 검사하기
// https://school.programmers.co.kr/learn/courses/30/lessons/118666

public class No05
{
    public string solution(string[] survey, int[] choices) {  
        // r,t / f,c / m,j / a,n  
        // 1 ~ 3 -> 앞에 + (4-n)    
        // 5 ~ 7 -> 뒤에 + (n-4)        
        // rt 1~3 : r ++ / 5~7 : r --  
        // tr 1~3 : r -- / 5~7 : r ++   
  
        int[] scores = new int[4];  
        string[] types = { "RT", "CF", "JM", "AN" };  
        for (int i = 0; i < choices.Length; i++)  
        {        
            switch (survey[i])  
            {            
                case "RT" : scores[0] += 4-choices[i]; break;  
                case "TR" : scores[0] += choices[i]-4; break;  
                case "CF" : scores[1] += 4-choices[i]; break;  
                case "FC" : scores[1] += choices[i]-4; break;  
                case "JM" : scores[2] += 4-choices[i]; break;  
                case "MJ" : scores[2] += choices[i]-4; break;  
                case "AN" : scores[3] += 4-choices[i]; break;  
                case "NA" : scores[3] += choices[i]-4; break;  
            }    
        }  
    
        string answer = "";  
        for(int i = 0; i < scores.Length; i++)  
        {        
            answer += scores[i] >= 0 ? types[i][0] : types[i][1];  
        }    
        return answer;  
    }
}

