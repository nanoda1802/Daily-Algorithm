namespace Daily_Algorithm._2025_10.day1016;

// [문제 설명] 덧칠하기
// https://school.programmers.co.kr/learn/courses/30/lessons/161989

public class No01
{
    public int solution(int n, int m, int[] section) {
        // 첫 벽부터 m 동안 칠하기 -> 도중에 만난 벽은 스킵
        // 이후 만난 벽마다 반복? 칠한 횟수 계산

        int paintCount = 0;

        int startWall = 0;
        int endWall = 0;
        
        for (int i = 0; i < section.Length; i++)
        {
            if (section[i] <= endWall)
            {
                continue;
            }
            
            startWall = section[i];
            endWall = startWall + m - 1;
            paintCount += 1;
        }

        return paintCount;
    }
}
