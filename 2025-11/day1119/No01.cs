namespace Daily_Algorithm._2025_11.day1119;
// 미로 탈출
// https://school.programmers.co.kr/learn/courses/30/lessons/159993

// 탈출 가능한 최소 시간
// 탈출 불가능하면 -1 (S-L, L-E 둘 중 하나가 안 될 때)
// S 입구 E 출구 L 레버 O 길 X 벽

// 매 칸 하는 일
// 1. 이번칸이 목표칸인지 확인해 기록 (L이나 E)
// 2. 상하좌우 확인해 갈 수 있는지 체크
// 갈수없음 : 다음칸이 X || 다음칸이 없음 (미로밖)
// 3. 갈 수 있는 칸으로 이동 BFS
// 4. 못 가면 -1 반환

// [핵심] BFS의 visited 체크는 큐에 넣을 때!!!!!!! (뺄 때 하면 중복 체크 발생)

public class No01
{
    int borderX, borderY, startX, startY;
    
    public int solution(string[] maps) {
        borderX = maps[0].Length;
        borderY = maps.Length;

        for (int i = 0; i < borderY; i++)
        {
            for (int j = 0; j < borderX; j++)
            {
                if (maps[i][j] == 'S')
                {
                    startX = j;
                    startY = i;
                }
            }
        }
        
        Queue<(int,int,int)> movements = new Queue<(int,int,int)>();

        int timeToL = BFS(maps,'L', movements);
        if (timeToL < 0) return -1;
        
        movements.Clear();
        
        int timeToE = BFS(maps,'E', movements);
        if (timeToE < 0) return -1;
        
        return timeToL + timeToE;
    }

    private int BFS(string[] maps, char goal, Queue<(int,int,int)> movements)
    {
        bool[,] visited = new bool[borderY, borderX];
        movements.Enqueue((startX, startY, 0));
        visited[startY, startX] = true;
        
        while (movements.Count > 0)
        {
            (int curX, int curY, int time) = movements.Dequeue();

            if (maps[curY][curX] == goal)
            {
                startX = curX;
                startY = curY;
                return time;
            }

            if (curX - 1 >= 0 && !visited[curY, curX - 1] && maps[curY][curX - 1] != 'X')
            {
                visited[curY, curX-1] = true;
                movements.Enqueue((curX - 1, curY, time+1));
            }

            if (curY - 1 >= 0 && !visited[curY - 1, curX] && maps[curY - 1][curX] != 'X')
            {
                visited[curY - 1, curX] = true;
                movements.Enqueue((curX, curY - 1, time+1));
            }

            if (curX + 1 < borderX && !visited[curY, curX + 1] && maps[curY][curX + 1] != 'X')
            {
                visited[curY, curX + 1] = true;
                movements.Enqueue((curX + 1, curY, time+1));
            }

            if (curY + 1 < borderY && !visited[curY + 1, curX] && maps[curY + 1][curX] != 'X')
            {
                visited[curY + 1, curX] = true;
                movements.Enqueue((curX, curY + 1, time+1));
            }
        }
        return -1;
    }
}

