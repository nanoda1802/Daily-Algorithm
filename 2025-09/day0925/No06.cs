namespace Daily_Algorithm._2025_09.day0925;

// [문제 설명] 소인수분해
// https://school.programmers.co.kr/learn/courses/30/lessons/120852

public class No06
{
    public int[] solution(int n)
    {
        // 2로 나눠봄
        // 1) 나머지 O -> 패스하고 3으로 나눠봄
        // 2) 나머지 X -> 2 추가하고 다시 2로 나눠봄 (반복)
        
        SortedSet<int> ss = new SortedSet<int>();
        
        for(int i = 2; i <= n; i++)
        {
            while(n % i == 0)
            {
                ss.Add(i);
                n /= i;
            }
        }
        
        return ss.ToArray();
    }
}

// [1] 2로 나누기: 먼저, 입력받은 수 n을 2로 나누어 떨어지는지 확인합니다.
// [2] 소수 찾기: 2로 나누어떨어지면 2를 소인수로 기록하고, 몫을 다시 n에 저장합니다. 이 과정을 2로 더 이상 나누어떨어지지 않을 때까지 반복합니다.
// [3] 홀수로 나누기: 2로 더 이상 나누어떨어지지 않으면, 3부터 시작하여 홀수 i로 나누어떨어지는지 확인합니다.
// [4] 반복: i로 나누어떨어지면 i를 소인수로 기록하고 몫을 n에 저장하며, i로 더 이상 나누어떨어지지 않을 때까지 반복합니다.
// [5] 반복 종료: n이 1이 될 때까지 이 과정을 반복합니다.