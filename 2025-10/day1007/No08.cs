namespace Daily_Algorithm._2025_10.day1007;

// [문제 설명] 최대공약수와 최소공배수
// https://school.programmers.co.kr/learn/courses/30/lessons/12940

public class No08
{
    public int[] solution(int n, int m) {
        int[] answer = new int[2];
        
        (int big, int small) = n > m ? (n, m) : (m, n);
        
        while (true)
        {
            int remainder = big % small;

            if (remainder <= 0) break;
            
            big = small;
            small = remainder;
        }

        answer[0] = small;
        answer[1] = n * m / small;
        
        return answer;
    }
}

// [메모] 최대공약수 구하기
// 1. 큰수 big과 작은수 small이 있음
// 2. big % small이 0이 될 때의 small이 두 수의 최대공약수
// 3. 0이 아니라면 big에 small을 할당하고, small엔 나머지를 할당 후 반복

// [메모] 최소공배수 구하기
// 1. "두 수의 곱 / 최대공약수"

// [다른 풀이1 - 삼항연산 + 재귀] "a가 b보다 크다는 확신이 있을 경우만 가능"
/*  
    private int gcd(int a, int b)
    {
        return (a % b == 0 ? b : gcd(b, a % b));
    }
*/