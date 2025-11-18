namespace Daily_Algorithm._2025_11.day1118;
// 호텔 대실
// https://school.programmers.co.kr/learn/courses/30/lessons/155651

// 최소 객실 수 구하기
// 객실은 퇴실시간 기준 10분 청소 후 사용 가능
// book_time은 [시작시각, 종료시각]

// 이거 그 IMOS 가능할 거 같은데
// IMOS 한 다음에 시간대 중 최대로 필요한 객실이 답
// 입장시간에 +1을, 퇴장시간에 -1을 기록해 두고 구간 업데이트 후 누적합을 계산

// 1점 뿐이 못 받았따 메모리를 많이 써서...?
// 그리디와 우선순위 큐로 해결하라는 게 출제자의 의도여씀...

public class No01
{
    public int solution(string[,] book_time)
    {
        int bookCount = book_time.GetLength(0);
        int[] imos = new int[1450];
        int lastTime = 0;

        for (int i = 0; i < bookCount; i++)
        {
            int start = TimeToInt(book_time[i, 0]);
            int end = TimeToInt(book_time[i, 1]) + 10;
            imos[start]++;
            imos[end]--;
            if (end > lastTime) lastTime = end;
        }

        int maxRoom = 0;
        
        for (int i = 1; i <= lastTime; i++)
        {
            imos[i] += imos[i-1];
            if (imos[i] > maxRoom) maxRoom = imos[i];
        }
        
        return maxRoom;
    }

    private int TimeToInt(string time)
    {
        string[] hm = time.Split(':');
        return int.Parse(hm[0]) * 60 + int.Parse(hm[1]);
    }
}

