namespace Daily_Algorithm._2025_09.day0921;

// [문제 설명] 순서쌍의 개수
// https://school.programmers.co.kr/learn/courses/30/lessons/120836

public class No13
{
    public  int solution(int n) {
        // 순서쌍은 뒤집을 수 있으니 그냥 약수의 개수인디, 홀수면... 그래도 그냥 약수의 개수임
        
        int answer = 0;
        
        for (int i = 1; i*i <= n; i++)
        {
            if (i * i == n) answer += 1;
            else if (n % i == 0) answer += 2;
        }

        return answer;
    }
}

// [메모] 약수의 개수를 구할 땐, 해당 수의 제곱근까지만 탐색해도 된다! 하지만 제곱근 연산 보단 다른 쪽을(=i) 제곱해 비교하는 걸로