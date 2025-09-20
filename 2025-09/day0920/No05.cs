namespace Daily_Algorithm._2025_09.day0920;

// [문제 설명] 피자 나눠먹기 2
// https://school.programmers.co.kr/learn/courses/30/lessons/120815

public class No05
{
    public int solution(int n) {
        // 6x % n == 0 인 x의 최소값

        int x = 1;
        
        while (true)
        {
            if ((6 * x) % n == 0) return x;
            x += 1;
        }
    }
}

// [다른풀이1 - 무슨 공식인 겨]
// return n / gcd(n, 6);

// 피자조각수가 n과 6의 최소공배수가 돼야함
// 최소공배수는 "두 수의 곱 / 두 수의 최대공약수", 즉 n*6/gcd 인데,
// 피자 수는 "피자조각수 / 6" 이니까 연산에 6을 나눈 "n/gcd"가 해답이 되는 것