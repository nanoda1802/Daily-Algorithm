namespace Daily_Algorithm._2025_12.d01;
// 우박수열 정적분
// https://school.programmers.co.kr/learn/courses/30/lessons/134239

// 2. x가 i-1 ~ i 인 영역의 넓이  
// 밑변 = 1, 높이는 (c(i-1) + c(i)) / 2 이므로 (c()는 콜라츠 연산 과정에서 등장한 수...)  
// 넓이는 (c(i-1) + c(i)) / 2
// 이걸 area[i] 라고 하기  
  
// 3. 그럼 a,b 에 대한 넓이는?  
// x가 a ~ n-b 인 영역의 넓이 (n은 콜라츠 동안 등장한 수의 총 개수)  
// 다만 a > n-b 인 경우, 시작과 끝이 반전돼 유효하지 않기 때문에 -1을 기록  
// a = n-b 인 경우는 0을 기록  
// 영역의 넓이는 area[a+1] ~ area[n-b] 까지의 누적합  
  
// 1. 콜라츠 추측을 연산하기  
// i번째 연산으로 등장한 수를 기록 (i는 0부터)  
// 그 수를 collatz[i] 라고 하기  
  
// [정리] 콜라츠 연산을하며 i번째 수의 넓이를 기록한 배열을 만들고, 영역이 주어질 때마다 해당 배열로 총 넓이를 구함

public class No01
{  
    public double[] solution(int k, int[,] ranges) {  
        double[] areas = GetAreas(k);  
        int cNumCount = areas.Length - 1; // 0번째가 k 본인이어서 -1로 제외  
        double[] answer = new double[ranges.GetLength(0)];  
    
        for (int i = 0; i < ranges.GetLength(0); i++)  
        {        
            int start = ranges[i, 0];  
            int end = cNumCount + ranges[i, 1];  
  
            if (start > end)  
            {            answer[i] = -1;  
                continue;  
            }  
            if (start == end)  
            {            answer[i] = 0;  
                continue;  
            }
                
            for (int j = start+1; j <= end; j++)  
            {            
                answer[i] += areas[j];        
            }    
        }   
     
        return answer;  
    }  
  
    private double[] GetAreas(int target)  
    {  
        List<int> cNums = new List<int>();  
        List<double> areas = new List<double>();  
        cNums.Add(target);  
        areas.Add(0);  
  
        while (cNums[cNums.Count-1] > 1)  
        {        
            int prev = cNums[cNums.Count-1];  
            if (prev % 2 == 0) cNums.Add(prev / 2);  
            else cNums.Add(prev * 3 + 1); 
                
            areas.Add(((double)cNums[cNums.Count-1] + cNums[cNums.Count-2]) / 2);  
        }  
        return areas.ToArray();  
    }
}