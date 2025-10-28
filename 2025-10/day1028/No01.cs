namespace Daily_Algorithm._2025_10.day1028;
// 영어 끝말 잇기
// https://school.programmers.co.kr/learn/courses/30/lessons/12981

// n 인원수 (1번 ~ n번) (2 <= n <= 10)  
// return 탈락자의 번호와 그 사람이 자신의 몇 번째 차례에 탈락하는지 [번호,차례]  
// 탈락자가 생기지 않는다면, [0, 0]을 return  
public class No01
{  
    public int[] solution(int n, string[] words)  
    {  
        // 탈락1 : 끝말 못 이었을 떄  
        // i-1 요소의 마지막 문자가 i 요소의 첫 문자와 다른지 확인
      
        // 탈락2 : 중복 단어 외쳤을 때  
        // i 기준 전 요소 중 중복이 있는지 확인 
     
        // 번호 : i % n + 1    
        // 차례 : i / n + 1  
      
        for (int i = 1; i < words.Length; i++)  
        {        
            string prev = words[i - 1];  
            if (!prev[prev.Length-1].Equals(words[i][0])) return new int[] { i%n+1, i/n+1 };  
  
            for (int j = 0; j < i; j++)  
            {            
                if (words[j].Equals(words[i])) return new int[] { i%n+1, i/n+1 };  
            }    
        }    
    
        return new int[2];  
    }
}