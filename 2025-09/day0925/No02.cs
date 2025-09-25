namespace Daily_Algorithm._2025_09.day0925;

// [문제 설명] 합성수 찾기
// https://school.programmers.co.kr/learn/courses/30/lessons/120846

public class No02
{
    public int solution(int n)
    {
        bool[] eratos = new bool[n+1];
        
        for (int i = 2; i*i <= n; i++)
        {
            if (eratos[i] == false)
            {
                for (int j = 2; j*i <= n; j++) eratos[j * i] = true;
            }
        }

        int answer = 0;
        
        foreach (bool b in eratos) if (b) answer += 1;
        
        return answer;
    }
}

// [메모 - 에라토스테네스의 체] 
// N 이하의 소수 판별에 활용 (이 문제엔 합성수 판별로 활용)
// < i=2 > 부터 < N의 제곱근 > 이하까지 순회
// i 본인 제외하고 i의 배수는 전부 X표시 (= 누군가의 배수는 소수가 절대 아니니까는)
// 이미 X 된 녀석 다시 방문 않도록 조건 부여 (= 문제에선 eratos[i]==false)
// 순회 마치면 소수 빼고 다 X 표시됨! 