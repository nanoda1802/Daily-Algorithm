namespace Daily_Algorithm._2025_09.day0919;

// [문제 설명] 분수의 덧셈
// https://school.programmers.co.kr/learn/courses/30/lessons/120808

public class No07
{
    public int[] solution(int numer1, int denom1, int numer2, int denom2) {
        int[] answer = new int[2];

        int numer = numer1 * denom2 + numer2 * denom1;
        int denom = denom1 * denom2;

        int gcd;
        
        if (numer == denom)
        {
            answer[0] = 1;
            answer[1] = 1;
        }
        else if (numer > denom)
        {
            gcd = getGCD(numer, denom);
            
            if (gcd == 1)
            {
                answer[0] = numer;
                answer[1] = denom;
            }
            else
            {
                answer[0] = numer / gcd;
                answer[1] = denom / gcd;
            }
        }
        else if (denom > numer)
        {
            gcd = getGCD(denom, numer);
            
            if (gcd == 1)
            {
                answer[0] = numer;
                answer[1] = denom;
            }
            else
            {
                answer[0] = numer / gcd;
                answer[1] = denom / gcd;
            }
        }
        
        return answer;
    }
    
    private int getGCD(int n, int m) // 큰수, 작은수
    {
        int remainder = n % m; 
        return remainder == 0 ? m : getGCD(m, remainder); // 작은수, 나머지결과 
    }
}

// [메모] 서로소인 두 수의 최대공약수이자 유일한 약수는 1