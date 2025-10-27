namespace Daily_Algorithm._2025_10.day1027;

// 다음 큰 숫자
// https://school.programmers.co.kr/learn/courses/30/lessons/12911

// 1. N은 n보다 큰 자연수
// 2. N과 n을 2진수로 변환했을 때, 1의 개수가 동일
// 3. N은 1번과 2번을 만족하는 최솟값

// 11111 -> 101111

// 11110 -> 100111

// 11101 -> 11110 
// 11011 -> 11101
// 10111 -> 11011

// 11100 -> 100011

// 11010 -> 11100
// 11001 -> 11010
// 10110 -> 11010
// 10101 -> 10110
// 10011 -> 10101

// 11000 -> 100001

// 10100 -> 11000
// 10010 -> 10100
// 10001 -> 10010

// 10000 -> 100000

// 제일 뒤의 01쌍을 찾음, 둘이 자리 바꿈
// 쌍 뒤에 1이 있다면 뒤로 밀착시킴
// 01쌍 없다면? 맨앞에 0 삽입 후 다시 해보기

// 규칙 찾은 걸로 풀고 싶었는데 c#의 한계인가 내가 못 하는 건가 ㅇ아아아앙ㅇ앙
// 정공법으로 풀었음...
public class No01
{  
    public int solution(int n) {  
        int countN = CountOne(n);  
  
        while (true)  
        {        
            n += 1;  
            if (countN == CountOne(n)) return n;  
        }
    }  
  
    private int CountOne(int n)  
    {  
        int cnt = 1;  
        for (int i = n; i > 1; i /= 2) if (i%2==1) cnt++;  
        return cnt;  
    }
}