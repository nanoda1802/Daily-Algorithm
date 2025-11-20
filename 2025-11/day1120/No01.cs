namespace Daily_Algorithm._2025_11.day1120;
// 숫자 카드 나누기
// https://school.programmers.co.kr/learn/courses/30/lessons/135807

// [핵심] GCD를 구할 때 두 수의 대소 비교가 필요 없음!! 자연스레 정렬이 된댜
// 예) n=4, m=6 -> 다음 n은 m(6)이고, 다음 m은 n%m(4) -> (6,4) 로 정렬돼씀 

public class No01
{
    /* 성공 케이스 */
    // 생각보다 시간 차가 없다?
    public int solution(int[] arrayA, int[] arrayB) {  
        int gcd1 = GCD2(arrayA);  
        int gcd2 = GCD2(arrayB);  
        return (gcd1 == gcd2) ? 0 : Math.Max(Check(gcd1, arrayB), Check(gcd2, arrayA));
    }  
    
    /* 실패 케이스 (딱 35번 하나...) */
    // 반복문 한 번에 처리하고 싶었으나 놓치는 케이스가 발생...
    public int solution2(int[] arrayA, int[] arrayB) {  
        int gcd1 = GCD2(arrayA);  
        int gcd2 = GCD2(arrayB);  
        if (gcd1 == gcd2) return 0;
        int max = 0;
        
        for (int i = 2; i <= Math.Max(gcd1,gcd2); i++)
        {
            if ((gcd1 % i == 0) == (gcd2 % i==0)) continue;
            if (max < i) max = i;
        }
        
        return max;  
    }  
  
    private int GCD(int n, int m)  
    {  
        return m == 0 ? n : GCD(m, n % m);  
    }  
  
    private int GCD2(int[] arr)  
    {  
        int gcd = arr[0];  
        for (int i = 1; i < arr.Length; i++)  
        {        
            gcd = GCD(gcd,arr[i]);  
            if (gcd == 1) return 1;  
        }    
        return gcd;  
    }

    private int Check(int num, int[] arr)
    {
        foreach (int i in arr) if(i % num == 0) return 0;
        return num;
    }
}

