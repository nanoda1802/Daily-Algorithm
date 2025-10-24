namespace Daily_Algorithm._2025_10.day1024;

// [문제설명] 가장 많이 받은 선물
// https://school.programmers.co.kr/learn/courses/30/lessons/258712

// 1. A와 B가 서로 최소 1회씩 선물 => 더 많이 준 쪽이 다음달 선물 1회 받음
// A가 B에게 선물을 5번 줬고, B가 A에게 선물을 3번 줬다면 다음 달엔 A가 B에게 선물을 하나 받습니다.

// 2. A와 B가 주고받은 수가 동일 => "선물지수" 높은 쪽이 다음달 선물 1회 받음
// 둘다 0번도 동일이제

// 3. 선물지수? 준 선물의 수에서 받은 선물의 수를 뺀 값

// 4. 선물지수도 동일하다면 다음달 아무일도 없음 

// 친구들의 이름을 담은 1차원 문자열 배열 friends ("친구이름")
// 이번 달까지 친구들이 주고받은 선물 기록을 담은 1차원 문자열 배열 gifts ("준사람 받은사람")
// 다음달에 가장 많은 선물을 받는 친구가 받을 선물의 수를 return

public class No04 
{  
    public int solution(string[] friends, string[] gifts)
    {
        // [1] 이름별 인덱스 지정
        int cnt = friends.Length;
        Dictionary<string, int> ids = new Dictionary<string, int>();
        for (int i = 0; i < cnt; i++) ids.Add(friends[i],i);

        // [2] 선물 주고받은 횟수 기록
        int[,] logs = new int[cnt,cnt];
        foreach (string gift in gifts)
        {
            string[] names = gift.Split(' ');
            logs[ids[names[0]], ids[names[1]]] += 1;
            // [메모] 여기서 선물지수도 바로바로 계산할 수 있었슴...
        }
        
        // [3] 선물지수 계산
        int[] scores = new int[cnt];
        for (int i = 0; i < cnt; i++)
        {
            for (int j = 0; j < cnt; j++)
            {
                scores[i] += logs[i, j];
                scores[i] -= logs[j, i];
            }
        }
        
        // [4] 다음달 선물 계산
        int[] points = new int[cnt];
        for (int i = 0; i < cnt-1; i++)
        {
            for (int j = i+1; j < cnt; j++)
            {
                int winner;
                if (logs[i,j] != logs[j,i])
                {
                    winner = logs[i, j] > logs[j, i] ? i : j;
                }
                else
                {
                    if(scores[i]==scores[j]) continue;
                    winner = scores[i] > scores[j] ? i : j;
                }
                points[winner] += 1;
            }
            // [메모] 여기서 바로바로 최고점 갱신할 수 있었슴...
        }
        
        // [5] 최고점 반환
        int maxPoint = 0;
        for (int i = 0; i < cnt; i++) maxPoint = Math.Max(maxPoint, points[i]);
        return maxPoint;
    }
}