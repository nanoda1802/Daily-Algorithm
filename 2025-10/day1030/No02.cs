namespace Daily_Algorithm._2025_10.day1030;
// 의상
// https://school.programmers.co.kr/learn/courses/30/lessons/42578

// 종류별로 0 ~ 1 개 착용  
// 최소 1개는 착용  
// clothes [의상의 이름, 의상의 종류]  
public class No02
{  
    public int solution(string[,] clothes) {  
        int answer = 1;  
  
        Dictionary<string,int> count = new Dictionary<string,int>();  
        for (int i = 0; i < clothes.GetLength(0); i++)  
        {        
            if (!count.TryAdd(clothes[i,1],1)) count[clothes[i,1]] += 1;  
        }  
    
        foreach (string key in count.Keys)  
        {        
            answer *= (count[key] + 1); // 안 입는 경우 고려  
        }  
    
        return answer - 1; // 아예 안 입은 경우 고려  
    }
}