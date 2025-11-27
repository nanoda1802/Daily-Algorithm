namespace Daily_Algorithm._2025_11.day1122;
// 배달
// https://school.programmers.co.kr/learn/courses/30/lessons/12978

// 음식 주문을 받을 수 있는 마을의 개수  
// 각 마을별 소요 시간을 구한 뒤 K 이하인 마을의 개수 return  
// road : 마을1, 마을2, 소요시간  

// 주의사항1 : 두 마을 a, b를 연결하는 도로는 여러 개가 있을 수 있습니다  
// 주의사항2 : 1번 마을에서 출발

// 멍충한 실수 목록
// 1. road의 행 길이와 N은 엄연히 다른데, road를 순회하는 반복문에서 N 보다 작은 인덱스로 map을 만들고 있었다... 운 좋게 통과한 다른 것들이 이상한 수준
// 2. 2차원 배열이니 (a,b)를 채웠으면 (b,a)도 채워야 했는데, 한 쪽만 채우고 앉았다...
// 분명 로직상 잘못된 부분이 없는데 왜 오답이 많을까 했는데 역시 다익스트라 쪽 보단 다른 곳에 문제가 있엇따... 허무하다...

public class No01
{
    public int solution(int N, int[,] road, int K)
    {
        int[,] map = new int[N, N];
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++) map[i, j] = -1;
        }

        for (int i = 0; i < road.GetLength(0); i++)
        {
            int town1 = road[i, 0] - 1, town2 = road[i, 1] - 1, time = road[i, 2];
            if (map[town1, town2] >= 0 && map[town1, town2] < time) continue;
            map[town1, town2] = map[town2, town1] = time;
        }

        int answer = 0;
        foreach (int time in Dijkstra(map, N))
        {
            if (time > K) continue;
            answer++;
        }

        return answer;
    }

    private int[] Dijkstra(int[,] map, int townCount)
    {
        bool[] visited = new bool[townCount];
        int[] times = new int[townCount];
        Array.Fill(times, int.MaxValue);
        times[0] = 0;

        while (true)
        {
            int minTime = int.MaxValue;
            int destination = -1;
            for (int i = 0; i < townCount; i++)
            {
                if (visited[i] || times[i] >= minTime) continue;
                minTime = times[i];
                destination = i;
            }

            if (destination == -1) break;
            visited[destination] = true;

            for (int i = 0; i < townCount; i++)
            {
                if (visited[i] ||
                    map[destination, i] < 0 ||
                    minTime + map[destination, i] >= times[i]) continue;
                times[i] = minTime + map[destination, i];
            }
        }

        return times;
    } 
    
    // [다른풀이] 딱 K 이하에 집중한 BFS 같은디  
    public int solution2(int N, int[,] road, int K)
    {
        int answer = 0;
        var distance = new int[N + 1]; // 최단거리(최단시간)배열    
        var queue = new Queue<int>(); // 탐색대상 큐    

        // 초기 값 세팅    
        for (int i = 0; i < distance.Length; i++)
            distance[i] = K + 1; // K보다 큰 수는 의미가 없으므로    
        distance[1] = 0; // 자기자신과의 거리는 0queue.Enqueue(1); // 유일하게 알고 있는 정점부터 탐색    

        // 갱신 대상이 없을 때까지 순회    
        while (queue.Count > 0)
        {
            int n = queue.Dequeue(); // 갱신 대상 마을 번호    
            // 갱신 대상과 연결된 간선을 탐색 (탐색 마을번호 i)
            for (int i = 0; i < road.GetLength(0); i++)
            {
                int n1 = road[i, 0]; // 1번 마을 번호    
                int n2 = road[i, 1]; // 2번 마을 번호    
                int dir = road[i, 2]; // 1번 마을 <-> 2번 마을    
                
                // 연결된 간선을 찾았다면 최소 값인지 체크해서 갱신    
                // 경로1 : 1 -> n1 -> n2, 경로2 : 1 -> n2 (else if는 반대)  
                // 경로2 보다 경로1이 빠르면 경로1으로 갱신  
                if (n == n1 && distance[n2] > dir + distance[n1])
                {
                    distance[n2] = dir + distance[n1];
                    queue.Enqueue(n2); // 갱신되었으므로 탐색 대상    
                }
                else if (n == n2 && distance[n1] > dir + distance[n2])
                {
                    distance[n1] = dir + distance[n2];
                    queue.Enqueue(n1); // 갱신되었으므로 탐색 대상    
                }
            }
        }

        foreach (int num in distance)
            if (num <= K)
                answer++;

        return answer;
    }

    // [다른풀이] 다익스트라여  
    public int solution3(int N, int[,] road, int K)
    {
        // 거리 초기화   
        int[,] map = new int[N, N];
        for (int i = 0; i < N; ++i)
        {
            for (int k = 0; k < N; ++k) map[i, k] = int.MaxValue;
        }

        for (int i = 0; i < road.GetLength(0); ++i)
        {
            int a = road[i, 0] - 1;
            int b = road[i, 1] - 1;
            int dist = road[i, 2];
            if (dist < map[a, b]) map[a, b] = map[b, a] = dist;
        }

        // 경로 찾기 전 초기화   
        var times = new int[N];
        var visit = new bool[N];
        for (int i = 0; i < N; ++i) times[i] = map[0, i];
        times[0] = 0;
        visit[0] = true;
        // 경로 찾기. 최초 시작위치에서 한개씩 확정짓기 때문에 시작노드를 제외한 N-1
        for(int repeat = 0; repeat < N - 1; ++repeat)   
        {
            int now = -1;
            int min = int.MaxValue;
            // 아직 방문하지 않은 노드 중 최단거리 찾기   
            for (int j = 0; j < N; ++j)
            {
                if (visit[j]) continue;
                if (times[j] == int.MaxValue) continue;
                if (times[j] >= min) continue;
                min = times[j];
                now = j;
            }

            visit[now] = true;
            for (int k = 0; k < N; ++k)
            {
                if (visit[k]) continue;
                if (map[now, k] == int.MaxValue) continue;
                // 직접 가는거보다 다른경로를 거쳐서 도달하는게 더 빠르면   
                if (times[k] > times[now] + map[now, k]) times[k] = times[now] + map[now, k];
            }
        }
        return times.Count(c => c <= K);
    }

    // [다른풀이] 2번과 비슷하게 매 지점마다 road를 순회하는데, 큐를 쓰지 않은 대신 반복문이 삼중...  
    public int solution4(int N, int[,] road, int K)
    {
        int answer = 0;
        int[] path = Enumerable.Repeat(int.MaxValue, N + 1).ToArray();
        // 1번부터 시작하니 한개를 추가함   
        path[1] = 0; // 시작지점 0
        for(int repeat = 0; repeat < N - 1; ++repeat)   
        {
            for (int target = 1; target < N + 1; ++target)
            {
                for (int r = 0; r < road.GetLength(0); ++r)
                {
                    int a = road[r, 0];
                    int b = road[r, 1];
                    int dist = road[r, 2];
                    // 더할 때 int.MaxValue라면 오버플로우 발생   
                    if (a == target && path[a] != int.MaxValue)
                    {
                        // 시작점 -> b 의 거리 보다 시작점 -> a -> b 의 거리가 더 짧다면 고침.   
                        path[b] = Math.Min(path[b], path[a] + dist);
                    }
                    else if (b == target && path[b] != int.MaxValue)
                    {
                        // 시작점 -> a 의 거리 보다 시작점 -> b -> a 의 거리가 더 짧다면 고침.   
                        path[a] = Math.Min(path[a], path[b] + dist);
                    }
                }
            }
        }
        return path.Count(c => c <= K);
    }
}