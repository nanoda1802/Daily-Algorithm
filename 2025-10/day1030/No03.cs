namespace Daily_Algorithm._2025_10.day1030;
// 피로도
// https://school.programmers.co.kr/learn/courses/30/lessons/87946

// 유저의 현재 피로도 k
// 각 던전별 "최소 필요 피로도", "소모 피로도"가 담긴 2차원 배열 dungeons
// 유저가 탐험할수 있는 최대 던전 수를 return  

// [메모] 시도중인 방법  
// 던전의 개수는 1 이상 8 이하 => 표본이 적어서 완전탐색이 괜춘  
  
// [메모] 이 방법은 실패  
// 우선순위1 : 소모피로드가 최소인 던전들  
// 우선순위2 : 그 중에 필요피로도가 최대인 던전  
// 정렬기준 : 소모피로도가 더 크면 뒤로 + 필요피로도가 더 작으면 뒤로  

// [메모] DFS, BFS, 백트래킹이 가능한 문제래

public class No03
{
    public int solution(int k, int[,] dungeons)  
    {  
        return DFS(dungeons, new bool[dungeons.GetLength(0)], k, 0, 0);  
    }  
  
    private int DFS(int[,] dungeons, bool[] visited, int tired, int cnt, int max)  
    {  
        //가장 큰 값을 변경해서 반환하기 위한 m    
        var m = max;  
        // 던전을 탐색합니다.  
        for (int i = 0; i < dungeons.GetLength(0); i++)  
        {        
            // 방문하지 않은 던전이면서 입장이 가능한지 확인합니다.  
            if (!visited[i] && tired >= dungeons[i, 0])  
            {            
                // 방문처리하고  
                visited[i] = true;  
                // 다른 던전을 탐색합니다.  
                m = DFS(dungeons, visited, tired - dungeons[i, 1], cnt + 1, m);  
                // i번을 들어갔다가 나온 경우 i+1을 들렸다가 갈 경우를 위해 false로 돌립니다.  
                visited[i] = false;  
            }    
        }    
        // 둘 중에 큰 값을 반환합니다.  
        return Math.Max(m, cnt);  
    }
}