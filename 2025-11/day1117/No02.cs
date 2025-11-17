namespace Daily_Algorithm._2025_11.day1117;
// 시소 짝꿍
// https://school.programmers.co.kr/learn/courses/30/lessons/152996

// 중심으로부터 2(m), 3(m), 4(m) 거리의 지점에 좌석이 하나씩  
// "탑승자 무게" X "중심-좌석 간 거리"의 곱이 양쪽 다 같다면 시소 짝꿍  
// w1 * m1 = w2 * m2  
// 바로 안 되는지 확인할 방법이 있을까...  

public class No02
{
    /* 성공... */
    public long solution(int[] weights) {  
        long answer = 0;
        // [1] 무게별 인원수 기록
        int maxWeight = 0; // 굳이 모든 경우 1000까지 확인할 필요 없으니
        int[] people = new int[1001]; // 인덱스=무게, 요소=인원
        foreach (int weight in weights)
        {
            people[weight]++;
            if (weight > maxWeight) maxWeight = weight;
        }
        
        // [2] 기준무게 당 조건에 맞는 무게의 인원수 체크
        // 오름차순으로 순회하기 때문에 현재무게보다 큰 경우만 확인하면 됨
        // 그 경우의 수가 1배, 4/3배, 3/2배, 2배
        for (int w = 100; w <= maxWeight; w++) 
        {
            if (people[w] == 0) continue;
            answer += (long)people[w]*(people[w]-1)/2;
            if (w % 3 == 0 && w * 4 / 3 <= maxWeight) answer += (long)people[w]*people[w*4/3];
            if (w % 2 == 0 && w * 3 / 2 <= maxWeight) answer += (long)people[w]*people[w*3/2];
            if (w * 2 <= maxWeight) answer += (long)people[w]*people[w*2];
        }
        
        return answer;  
    }  
  
    /* 시간초과 실패 */
    // 2/2 2/3 2/4 3/2 3/3 3/4 4/2 4/3 4/4  
    // 1 2/3 1/2 3/2 1 3/4 2 4/3 1  
    // 1/2 2/3 3/4 1 4/3 3/2 2  
    // {1,2}, {2,3}, {3,4}, {1,1}, {4,3}, {3,2}, {2,1}   
    public long FailedSolution(int[] weights) {  
        long answer = 0;  
        int[,] nums = { { 1, 2 }, { 2, 3 }, { 3, 4 }, { 1, 1 }, { 4, 3 }, { 3, 2 }, { 2, 1 } };  
  
        int w1 = 0;  
        int w2 = 1;  
  
        while (w1 < weights.Length-1)  
        {        
            for (int i = 0; i < nums.GetLength(0); i++)  
            {            
                if (weights[w1] * nums[i, 0] == weights[w2] * nums[i, 1])  
                {                
                    answer++;               
                    break;  
                }        
            }  
            w2++;        
            if (w2 == weights.Length)  
            {           
                w1++;           
                w2 = w1 + 1;  
            }
        }    
        return answer;  
    }
}
