namespace Daily_Algorithm._2025_10.day1025;

// 이진 변환 반복
// https://school.programmers.co.kr/learn/courses/30/lessons/70129

// s가 "1"이 될 때까지 계속해서 s에 이진 변환
// 이진 변환의 횟수와 제거된 모든 0의 개수를 배열에 담아 return

// s의 모든 0을 제거합니다.
// s의 길이를 c라고 하면, s를 "c를 2진법으로 표현한 문자열"로 바꿉니다

public class No05
{ 
    public int[] solution(string s) {
        int[] answer = new int[2];

        // 계속 int로 계산 할 것이여
        // 우선 s 따로 계산해
        // s의 1의개수 n을 구하고, 0의개수는 answer[1]에 더해
        // 연산 한 번 했으니까 answer[0]에 1 더해
        int n = 0;
        foreach (char c in s)
        {
            if (c.Equals('1')) n++;
            else answer[1]++;
        }

        answer[0] += 1;
        
        // 그리고 루프 시작
        while (true)
        {
            if (n <= 1) break;
            int n2 = 1;
            
            for (int i = n; i > 1; i /= 2)
            {
                if (i % 2 == 0) answer[1]++;
                else n2++;
            }

            answer[0] += 1;
            n = n2;
        }
        
        // n을 계속 2로 나누면서 나머지가 0이면 answer[1]에 더하고,
        // 나머지가 1이면 n2에 세기
        // 다 했으면 n2에 1 더하기 (마지막 나머지)
        // 연산 한 번 했으니까 answer[0]에 1 더해
        // n2 기준으로 다시 루프 시작
        
        // n이 2가 될 때까지 연산 후 반환
        
        return answer;
    }
}

// [메모] Linq와 Convert로 2진법 딸깍 풀이가 있따 int는 쓰지도 않는다...
// 그쪽 성능이 나았을지도 모르겄다... 이쪽이 중첩반복인 이상... 