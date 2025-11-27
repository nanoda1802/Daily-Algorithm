namespace Daily_Algorithm._2025_11.day1127;
// 리코쳇 로봇
// https://school.programmers.co.kr/learn/courses/30/lessons/169199

// bfs로 어렵지 않게 해결했는데, 하나 찝찝했던 점은 시작위치 R을 찾기 위한 board 탐색
// 최악의 경우 board 전체를 순회해야 해서 어차피 다 도는 거 장애물 D나 도착점 G를 표시하고 싶었으나 아이디어가 떠오르지 않아 패스했는데, 다른 풀이 중 해낸 분 발견
// 나만의 board를 이차원배열로 하나 만듦, 4가지 경우의 수 표현이 필요해서 int의 -3 -2 -1 0으로 하셨음
// 그래서 D는 -3으로 못 가는 칸, G는 -2으로 도착 칸, R은 -1로 출발 칸, 그리고 초기화된 0은 아직 안 간 칸으로 했더라
// 그래서 가본 칸은 1로 바꿔서, visited도 쓸 필요 없이 하나의 이차원 배열을 만들어놓고 훨씬 빠르게 처리가 가능했었음... 
public class No02
{
    public int solution(string[] board) {  
        int lenY = board.Length;  
        int lenX = board[0].Length;  
        Queue<(int,int,int)> bfs = new Queue<(int,int,int)>();  
        bool[,] visited = new bool[lenY, lenX];  
        for (int i = 0; i < lenY; i++)  
        {        
            int idx = board[i].IndexOf('R');  
            if (idx == -1) continue;  
            bfs.Enqueue((i,idx,0));  
            visited[i,idx] = true;  
            break;  
        }  
        int[] dirY = { 1, -1, 0, 0 };  
        int[] dirX = { 0, 0, -1, 1 };  
        while (bfs.Count > 0)  
        {        
            (int startY, int startX, int depth) = bfs.Dequeue();  
            if (board[startY][startX] == 'G') return depth;   
            for (int i = 0; i < 4; i++)  
            {            
                int nextY = startY, nextX = startX;  
  
                while (nextY >= 0 && nextX >= 0 && nextY < lenY && nextX < lenX)  
                {                
                    nextY += dirY[i];                
                    nextX += dirX[i];                
                    if (nextY != -1 && nextX != -1 && nextY != lenY && nextX != lenX && board[nextY][nextX] != 'D') continue;  
                    int curY = nextY - dirY[i], curX = nextX - dirX[i];  
                    if (visited[curY, curX]) break;  
                    bfs.Enqueue((curY, curX, depth + 1));  
                    visited[curY, curX] = true; break;  
                }        
            }    
        }  
        return -1;  
    }
}

