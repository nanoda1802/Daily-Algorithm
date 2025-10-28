namespace Daily_Algorithm._2025_10.day1028;
// 예상 대진표
// https://school.programmers.co.kr/learn/courses/30/lessons/12985

// 1번↔2번, 3번↔4번, ... , N-1번↔N번의 참가자끼리 게임을 진행  
// 1번↔2번 끼리 겨루는 게임에서 2번이 승리했다면 다음 라운드에서 1번을 부여받고, 3번↔4번에서 겨루는 게임에서 3번이 승리했다면 다음 라운드에서 2번을 부여  
// A번을 가진 참가자는 경쟁자로 생각하는 B번 참가자와 몇 번째 라운드에서 만나는지 return
// A번 참가자와 B번 참가자는 서로 붙게 되기 전까지 항상 이긴다  
public class No02
{  
    public int solution(int n, int a, int b)  
    {  
        // x의 다음 번호 : (x+1) / 2    
        int round = 0;  
  
        while (true)  
        {        
            round++;        
            a = (a + 1) / 2;  
            b = (b + 1) / 2;  
  
            if (a == b) return round;  
        }
    }
}

// [다른 풀이] 구역을 나눠서 어찌어찌 한다는데...  
// 1. 같은 구간에 있으면 이번 라운드에선 만나지 않음
// 2. round를 내리고, 구간을 줄임
// 3. 다른 구간이 되는 순간이 만나는 round

/*
public int solution(int n, int a, int b)
{
    int round = (int)Math.Log(n, 2); // 최종라운드가 몇차전인지 저장
    int nAreaStart = 1;
    int nAreaEnd = n;
    while (round > 0)
    {
        int nMid = (nAreaStart + nAreaEnd - 1) / 2;
        if (a <= nMid && b <= nMid) // 둘다 왼쪽 구간이면
        {
            round--;
            nAreaEnd = nMid;
        }
        else if (a > nMid && b > nMid) // 둘다 오른쪽 구간이면
        {
            round--;
            nAreaStart = nMid + 1;
        }
        else break; // 절반으로 나눠서 다른 구간에 있으면 그 라운드에서 만남
    }
    return round;
}
*/