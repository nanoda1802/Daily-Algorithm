namespace Daily_Algorithm._2025_11.day1128;
// 무인도 여행
// https://school.programmers.co.kr/learn/courses/30/lessons/154540

// 섬을 하나 만나면, 그 섬을 "다" 돌아봐야함 dfs?  

// 필드를 활용해갖고 클래스 통째로 들구옴
// 드디어 dfs를 해냈어!!! 핵심은 반복문 내부에서의 재귀 발동과 return값의 누적이여야요!
public class No01
{
    bool[,] visited;  
    int[] dy = { 1, -1, 0, 0 };  
    int[] dx = { 0, 0, 1, -1 };  
    // maps를 순회하다 X가 아니고, 방문하지 않은 칸을 만나면 섬 도착  
    // 섬의 상하좌우를 돌며 이 섬의 체류 가능일 합산 + 해당 좌표엔 방문 표시  
    public int[] solution(string[] maps) {  
        int lenX = maps[0].Length;  
        int lenY = maps.Length;  
        visited = new bool[lenY, lenX];  
        List<int> islandInfo = new List<int>();  
        for (int y = 0; y < lenY; y++)  
        {            
            for (int x = 0; x < lenX; x++)  
            {                
                if (visited[y, x]) continue;  
                visited[y, x] = true;  
                if (maps[y][x] == 'X') continue;  
                int sum = DFS(maps, x, y, lenX, lenY);  
                islandInfo.Add(sum);  
            }        
        }  
        if (islandInfo.Count <= 0) return new int[] {-1};  
        islandInfo.Sort();  
        return islandInfo.ToArray();  
    }  
    // 중단 조건? 더 이상 갈 수 있는 칸이 없을 때  
    // 갈 수 있는 칸? 상하좌우로 연결돼있으며, 방문한 적 없는 칸  
    private int DFS(string[] maps, int x, int y, int lenX, int lenY)  
    {        
        int sum = maps[y][x] - '0';  
  
        for (int i = 0; i < 4; i++)  
        {            
            int nextX = x + dx[i], nextY = y + dy[i];  
            if (nextX < 0 || nextY < 0) continue;  
            if (nextX >= lenX || nextY >= lenY) continue;  
            if (visited[nextY, nextX]) continue;  
            if (maps[nextY][nextX] == 'X') continue;  
            visited[nextY, nextX] = true;  
            sum += DFS(maps, nextX, nextY, lenX, lenY);  
        }        
        return sum;  
    }
}

