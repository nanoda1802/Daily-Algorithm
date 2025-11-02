namespace Daily_Algorithm._2025_11.day1102;
// 게임 맵 최단거리
// https://school.programmers.co.kr/learn/courses/30/lessons/1844

public class No01
{  
    public int solution(int[,] maps)
    {
        Queue<(int, int, int)> route = new Queue<(int, int, int)>();
        route.Enqueue((0,0,1));
        
        int limitX = maps.GetLength(1);
        int limitY = maps.GetLength(0);
        bool[,] visited = new bool[limitY,limitX];
        visited[0, 0] = true;
        
        while (route.Count > 0)
        {
            (int curX, int curY, int depth) = route.Dequeue();
            
            if (curX == limitX - 1 && curY == limitY - 1) return depth;
            
            depth++;
            
            if (curX + 1 < limitX && !visited[curY,curX+1] && maps[curY,curX+1] != 0)
            {
                visited[curY, curX+1] = true;
                route.Enqueue((curX+1,curY,depth));
            }
            if (curY + 1 < limitY && !visited[curY+1,curX] && maps[curY+1,curX] != 0)
            {
                visited[curY+1, curX] = true;
                route.Enqueue((curX,curY+1,depth));
            }
            if (curX - 1 >= 0 && !visited[curY,curX-1] && maps[curY,curX-1] != 0)
            {
                visited[curY, curX-1] = true;
                route.Enqueue((curX-1,curY,depth));
            }
            if (curY - 1 >= 0 && !visited[curY-1,curX] && maps[curY-1,curX] != 0)
            {
                visited[curY-1, curX] = true;
                route.Enqueue((curX,curY-1,depth));
            }
        }
        
        return -1;
    }
}

// BFS 해냈다!!!! 튜플이 돼서 다행이다 근데 이동 가능 여부 확인하는 부분이 맘에 들지 않아... 근데 나처럼 그냥 조건문 네번한 사람 꽤 되넹
// 현재위치 (부모) 이동가능한위치 (자식)
// 직전에 방문했거나, 벽이거나, 맵 밖이면 갈 수 없음
    
// [1] (0,0,1)을 큐에 넣고 시작 (x,y,depth)
// [2] (0,0,1)을 빼고 현위치 curPos로 지정, depth에 1 더함
// [3] curPos의 이동가능한 위치 pos들을 큐에 넣음
// [4] pos들 대상으로 2~3 반복
// [5] 뺀 pos가 (n,m)이면 이 pos의 depth 반환

// [메모] 효율성이 걸렸던 이유
// 좌표를 뺀 후 방문 체크를 하면, 같은 좌표가 여러 번 들어가는 경우 발생

// 일단 문제 풀이는 BFS로 풀면 최단 거리를 보장하기에 정답이 나옴
// 많은 BFS들은 dequeue한 이후에 visit 처리와 같은 걸 하는데
// 이 문제에서는 enqueue와 동시에 visit처리를 해서 중복된 위치에 다시 탐색하지 않는 것이 핵심
// 올바르게 중복된 탐색을 제외하면 nxm = 10,000회 방문만으로 끝나지만
// 그렇지 않다면 최악의 경우 (완전히 열린 맵) 1+2+4+8+16+...+2^99 회의 방문이 만들어짐