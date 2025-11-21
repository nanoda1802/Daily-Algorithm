namespace Daily_Algorithm._2025_11.day1121;
// 서버 증설 횟수
// https://school.programmers.co.kr/learn/courses/30/lessons/389479

// m명 당 서버 1대 추가
// 서버 수명 k시간
// 최소 증설 횟수 return

// 시간당 이용자 수 0~1000
// m 도 0~1000
// k는 1~24

// 이게 왜 2레벨...?
// 아무튼 이 방식이 출제자의 의도는 아닌 것 같다
// Queue를 활용하는 게 정석인 듯 한데! 큐 쓴 거 보단 속도가 빠르다 워째서
// 아무튼...

public class No01
{
    public int solution(int[] players, int m, int k) {
        int[] servers = new int[players.Length];
        int cnt = 0;
        
        for (int i = 0; i < players.Length; i++)
        {
            int diff = players[i] - servers[i] * m;
            if (diff >= m)
            {
                int add = diff / m;
                cnt += add;
                for (int j = 0; j < k; j++)
                {
                    if (i+j >= 24) break;
                    servers[i+j] += add;
                }
            }
        }
        
        return cnt;
    }
}

