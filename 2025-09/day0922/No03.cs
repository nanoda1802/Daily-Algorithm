namespace Daily_Algorithm._2025_09.day0922;

// [문제 설명] 진료순서 정하기
// https://school.programmers.co.kr/learn/courses/30/lessons/120835

public class No03
{
    public int[] solution(int[] emergency)
    {
        int len = emergency.Length;
        int[] copy = new int[len];
        int[] answer = new int[len];
        Array.Copy(emergency,copy,len);

        Array.Sort(emergency,(p,n)=>n-p);
        
        for (int i = 0; i < len; i++)
        {
            int idx = Array.IndexOf(copy, emergency[i]);
            answer[idx] = i+1;
        }
        
        return answer;
    }
}

// [다른풀이1 - Array.Sort 오버로딩]
/*
    int[] order = new int[emergency.Length];
    
    for (int i = 0; i < order.Length; i++)
        order[i] = order.Length - i;
    
    Array.Sort(emergency, order);  // -> 뒤 배열의 요소들이 정렬의 key값이 돼줌
    
    return order;
*/