namespace Daily_Algorithm._2025_10.day1027;
// N개의 최소공배수
// https://school.programmers.co.kr/learn/courses/30/lessons/12953

// n개의 수의 최소공배수는 n 개의 수들의 배수 중 공통이 되는 가장 작은 숫자 
public class No06
{  
    public int solution(int[] arr) {  
        // 2 6 8 14 (오름차순 정렬)  
        // 6 6 8 14 (0번과 1번의 최소공배수 맞추기)  
        // 24 24 24 14 (1번과 2번의 최소공배수 맞추기)  
        // 168 168 168 168 (2번과 3번의 최소공배수 맞추기)  
        Array.Sort(arr);  
        for (int i = 0; i < arr.Length-1; i++)  
        {        
            arr[i+1] = lcm(arr[i+1], arr[i]);  
        }    
        return arr[arr.Length-1];  
    }  
  
    private int gcd(int a, int b)  
    {  
        return b == 0 ? a : gcd(b, a % b);  
    }  
  
    private int lcm(int a, int b)  
    {  
        return a * b / gcd(a, b);  
    }
}