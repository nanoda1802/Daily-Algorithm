namespace Daily_Algorithm._2025_10.day1027;
// 귤고르기
// https://school.programmers.co.kr/learn/courses/30/lessons/138476

// 귤 k개를 고를 때 크기가 서로 다른 종류의 수의 최솟값을 return  
public class No04
{
    public int solution(int k, int[] tangerine) {  
        int[] ord = tangerine.GroupBy(e=>e)  
            .Select(e=>e.Count())  
            .OrderByDescending(e=>e)  
            .ToArray();  
  
        for (int i = 0; i < ord.Length; i++)  
        {        
            k -= ord[i];        
            if (k <= 0) return i + 1;  
        }    
    
        return -1;  
    }
}