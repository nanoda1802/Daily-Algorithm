namespace Daily_Algorithm._2025_10.day1017;

// [문제 설명] 소수 찾기
// https://school.programmers.co.kr/learn/courses/30/lessons/12921

public class No01
{
    public int solution(int n)
    {
        bool[] eratos = new bool[n + 1];
        eratos[0] = eratos[1] = true;

        for (int i = 2; i*2 <= n; i++)
        {
            eratos[i * 2] = true;
        }

        for (int i = 3; i <= n; i += 2)
        {
            for (int j = 2; j*i <= n; j++)
            {
                if (eratos[j * i]) continue;
                eratos[j * i] = true;
            }
        }
        
        int answer = 0;

        foreach (bool isNotPrime in eratos)
        {
            if (!isNotPrime) answer += 1;
        }
        
        return answer;
    }
}

// [다른풀이1 - 이것도 에라토스 원리인디 훨씬 간결하네...]
/*
public int solution(int n) {
    int answer = 0;
    bool[] arr = new bool[n + 1];

    for(int i = 2; i < n + 1; i++) {
        if(!arr[i]) {
            answer++;
            for(int j = 2; i * j < n + 1; j++) arr[i * j] = true;
        }
    }

    return answer;
}
*/