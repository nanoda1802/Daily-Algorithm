namespace Daily_Algorithm._2025_10.day1028;
// 연속 부분 수열 합의 개수
// https://school.programmers.co.kr/learn/courses/30/lessons/131701

public class No03
{  
    public int solution(int[] elements) {  
        HashSet<int> sums = new HashSet<int>();  
  
        for (int i = 0; i < elements.Length; i++)  
        {        
            int sum = 0;
	      
            for (int j = 0; j < elements.Length; j++)  
            {            
                sum += elements[(i + j) % elements.Length];  
                sums.Add(sum);  
            }    
        }    
    
        return sums.Count;  
    }
}

// [메모] 누적합과 Set...?
// 우선 누적합은 3중첩 반복문을 피하기 위해 필요 (거의 1000ms에서 10ms로 하락)  
// Set은 중복값을 편하게 배제하기 위해 필요  
// 각 요소마다 결국 이어진 다른 요소들과의 합을 배열 길이만큼 구해봐야함  
// 원순열이기 때문에 이어진 다른 요소들과의 합 => 다음요소 더하기, 다음요소 더하기, ... 의 반복  
// 그래서 누적합을 구하는 과정의 매 합이 구하고자 하는 합들과 같은 것!