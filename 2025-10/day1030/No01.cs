namespace Daily_Algorithm._2025_10.day1030;
// H-Index
// https://school.programmers.co.kr/learn/courses/30/lessons/42747

// n개 중, h번 이상 인용된 게 h개 이상일 때 h의 최댓값  
  
// citations의 i번째 요소를 e라고 하고, 배열의 e와 같은 요소의 개수를 n이라 할 때,  
// h는 e와 n 중 최소값이고, 그런 h중의 최댓값이 return 해야할 값임...  
// 예를 들어 [5,5,5,5] 에서, 5번 인용된 횟수가 4회 뿐이기 때문에, 5는 h의 조건에 부합하지 않음  
// 따라서 배열엔 존재하지 않지만 h의 조건에는 부합하는 4가 정답인데, 이 4가 바로 같은 요소의 개수임...  

// hs의 인덱스 = 인용횟수
// hs의 요소 = 인덱스 이상 인용된 횟수
// 누적합으로 풀이...!
public class No01
{  
    public int solution(int[] citations) { 
        int[] hs = new int[10001];  
  
        int maxCitation = 0;  
        foreach (int citation in citations)  
        {        
            if (maxCitation < citation) maxCitation = citation;  
            for (int i = 0; i <= citation; i++) hs[i] += 1;  
        }    
    
        int hIndex = 0;  
        for (int i = 0; i <= maxCitation; i++)  
        {        
            int h = hs[i] < i ? hs[i] : i;  
            if (hIndex < h) hIndex = h;  
        }    
    
        return hIndex;  
    }
}