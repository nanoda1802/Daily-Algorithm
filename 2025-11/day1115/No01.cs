namespace Daily_Algorithm._2025_11.day1115;
// 삼각 달팽이
// https://school.programmers.co.kr/learn/courses/30/lessons/68645

// 현위치 curPos를 방향 dir대로 이동시키며 num을 삽입
// 초기 dir은 (0,1)
// 다음 위치가 n을 초과한 좌표거나, 이미 값이 있는 좌표라면 방향 전환
// 전환은 (0,1) -> (1,0) -> (-1,-1) -> (0,1)을 순환
// 전환했는데 다음 위치에 값이 있으면 종료
// 이차원배열 순회하며 순서대로 배열에 입력
// 요소가 0이면 다음 행 확인

public class No01
{
    public int[] solution(int n) {
        List<int> answer = new List<int>();
        
        int[] curPos = { 0,0 };
        int[,] dir = { { 1, 0 }, { 0, 1 }, { -1, -1 } };
        int curDir = 0;

        int[,] snail = new int[n,n];
        int num = 1;

        while (true)
        {
            snail[curPos[0], curPos[1]] = num++;

            int nextY = curPos[0] + dir[curDir, 0];
            int nextX = curPos[1] + dir[curDir, 1];

            if (nextX >= n || nextY >= n || snail[nextY,nextX] > 0)
            {
                curDir = (curDir + 1) % 3;
            }
            
            nextY = curPos[0] + dir[curDir, 0];
            nextX = curPos[1] + dir[curDir, 1];

            if (nextX >= n || nextY >= n || snail[nextY,nextX] > 0) break;

            curPos[0] = nextY;
            curPos[1] = nextX;
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (snail[i,j] <= 0) break;
                answer.Add(snail[i,j]);
            }
        }
        
        return answer.ToArray();
    }
}

