namespace Daily_Algorithm._2025_11.day1111;
using System.Text;
// k진수에서 소수 개수 구하기
// https://school.programmers.co.kr/learn/courses/30/lessons/92335

// k 진수를 0으로 구분했을 때 나온 수 중 소수의 개수  
public class No01
{
    public int solution(int n, int k) {  
        int answer = 0;  
        StringBuilder sb = new StringBuilder();  
  
        while (n > 0)  
        {        
            sb.Insert(0, n%k);  
            n /= k;    
        }   
     
        string[] nums = sb.ToString().Split('0', StringSplitOptions.RemoveEmptyEntries);  
  
        foreach (string num in nums)  
        {        
            if (IsPrime(long.Parse(num))) answer++;  
        }  
    
        return answer;  
    }  
  
    private bool IsPrime(long n)  
    {  
        if ((n < 2) || ((n != 2) && (n % 2 == 0))) return false;  
        for (long i = 3; i * i <= n; i += 2)  
        {        
            if (n % i == 0) return false;  
        }    
        return true;  
    }
}

