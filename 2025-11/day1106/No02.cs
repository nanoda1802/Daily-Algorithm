namespace Daily_Algorithm._2025_11.day1106;
// 롤케이크 자르기
// https://school.programmers.co.kr/learn/courses/30/lessons/132265

// 각 조각에 동일한 가짓수의 토핑이 올라가면 공평하게 롤케이크가 나누어진 것  
  
// 토핑들의 번호를 저장한 정수 배열 topping
// 롤케이크를 공평하게 자르는 방법의 수를 return  

// 토핑들이 [1, 2, 1, 3, 1, 4, 1, 2]
// 네 번째 토핑(3)과 다섯 번째 토핑(1) 사이를 자르면 [1, 2, 1, 3], [1, 4, 1, 2]
// 1,2,3 세개, 1,2,4 세개로 공평  
// [1, 2, 1, 3, 1], [4, 1, 2]으로 잘라도 공평  
  
// DP...?  
// (i = 1) 부터 피벗 출발  
// 좌측 보관 arr1 + 우측 보관 arr2
// i가 증가하면?  
// 우측보관 첫번째 녀석을 좌측보관 마지막에 투입  
// 공평하면 count++
// (i = topping.length-1) 까지 반복  
  
// 공평한지 판단...?  
// 딕셔너리로 토핑별 개수 보관...  
// 토핑 옮길 때 딕셔너리만 최신화  
// dic.Keys.Count 비교해 같으면 공평...  
public class No02
{  
    public int solution(int[] topping) {  
        int answer = 0;  
        Dictionary<int, int> topA = new Dictionary<int, int>();  
        Dictionary<int, int> topB = new Dictionary<int, int>();  
    
        for (int i = 0; i < topping.Length; i++)  
        {        
            if (!topB.TryAdd(topping[i], 1)) topB[topping[i]] += 1;  
        }    
    
        for (int i = 1; i < topping.Length; i++)  
        {        
            int prev = topping[i - 1];  
            topB[prev] -= 1;  
            if (topB[prev] <= 0) topB.Remove(prev);  
        
            if (!topA.TryAdd(prev, 1)) topA[prev] += 1;  
        
            if (topA.Keys.Count == topB.Keys.Count) answer++;  
        }    
    
        return answer;  
    }
}

// [다른풀이] Set 이용 이게 더 깔끔  
/*
public int solution(int[] topping) {
    int answer = 0;
    HashSet<int> hashsetA = new HashSet<int>();
    HashSet<int> hashsetB = new HashSet<int>();
    int[] counts = new int[topping.Length];

    for(int i = 0; i < topping.Length ; i++)
    {
        hashsetA.Add(topping[i]);
        counts[i] = hashsetA.Count;
    }

    for(int i = topping.Length-1; i > 0 ; i--)
    {
        hashsetB.Add(topping[i]);
        if(counts[i-1] == hashsetB.Count) answer++;
    }

    return answer;
}
*/