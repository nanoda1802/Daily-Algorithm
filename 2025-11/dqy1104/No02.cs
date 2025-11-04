namespace Daily_Algorithm._2025_11.day1104;
// 전력망을 둘로 나누기
// https://school.programmers.co.kr/learn/courses/30/lessons/86971

// 송전탑의 개수 n, 그리고 전선 연결 정보 wires
// 전선들 중 하나를 끊어서 송전탑 개수가 가능한 비슷하도록 두 전력망으로 나누었을 때,  
// 두 전력망이 가지고 있는 송전탑 개수의 차이(절대값)를 return  

// A노드에서 부모와의 연결을 끊었다  
// A 포함 A의 자식노드 개수 x
// 두 전력망의 탑 개수는 각각 x와 n-x  
// 그럼 1번탑 제외 탑을 돌면서 각각의 x를 구해  
// 그리고 두 전력망 차이가 최소인 걸 리턴?  

// 성실하게 끊었다 이었다 하며 푼 코드..........

public class No02
{  
    public int solution(int n, int[,] wires) {  
        int answer = int.MaxValue;

        Tower[] towers = new Tower[n+1];
        for (int i = 1; i <= n; i++) towers[i] = new Tower(i);

        for (int i = 0; i < wires.GetLength(0); i++)
        {
            Connect(towers,wires[i,0],wires[i,1]);
        }

        for (int i = 0; i < wires.GetLength(0); i++)
        {
            DisConnect(towers,wires[i,0],wires[i,1]);
            
            int count = 1;
            DFS(towers,new bool[towers.Length],wires[i,0],ref count);

            Connect(towers,wires[i,0],wires[i,1]);

            int differ = Math.Abs((n - count) - count);
            if (answer > differ) answer = differ;
        }
        
        return answer;  
    }

    private void Connect(Tower[] towers, int x, int y)
    {
        towers[x].connection.Add(towers[y]);
        towers[y].connection.Add(towers[x]);
    }

    private void DisConnect(Tower[] towers, int x, int y)
    {
        towers[x].connection.Remove(towers[y]);
        towers[y].connection.Remove(towers[x]);
    }

    private void DFS(Tower[] towers,bool[] visited, int from, ref int count)
    {
        visited[from] = true;
        
        foreach (Tower to in towers[from].connection)
        {
            if (visited[to.num]) continue;
            count++;
            DFS(towers, visited,to.num, ref count);
        }
    }
    
    class Tower
    {
        public int num;
        public HashSet<Tower> connection;

        public Tower(int num)
        {
            this.num = num;
            connection = new HashSet<Tower>();
        }
    }
}

// [다른풀이]
// 모든 노드의 자식의 개수를 구해두기
// 리프노드들에서부터 각 노드의 자식의 개수 구하며 올라가기
// ㅁㄴ이;러ㅏㅁㄴㅇㄹ??

// [다른풀이] nXn 배열로 연결관계 나타내기
// (1,2) 가 true면 1에서 2로 갈 수 있다는 뜻

/*
public int solution(int n, int[,] wires)
{
    bool[,] data = new bool[n, n];

    for (int i = 0; i < wires.GetLength(0); i++)
    {
        data[wires[i, 0] - 1, wires[i, 1] - 1] = true;
        data[wires[i, 1] - 1, wires[i, 0] - 1] = true;
    }

    bool[] path;
    int answer = int.MaxValue;
    for (int i = 0; i < wires.GetLength(0); i++)
    {
        data[wires[i, 0] - 1, wires[i, 1] - 1] = false;
        data[wires[i, 1] - 1, wires[i, 0] - 1] = false;

        path = new bool[n];
        DFS(0, data, path);
        answer = Math.Min(answer, Math.Abs(path.Count(x => x) * 2 - n));

        data[wires[i, 0] - 1, wires[i, 1] - 1] = true;
        data[wires[i, 1] - 1, wires[i, 0] - 1] = true;
    }

    return answer;
}

private void DFS(int current,bool[,] data, bool[] path)
{
    path[current] = true;

    for (int i = 0; i < data.GetLength(1); i++)
    {
        if (data[current, i] && !path[i])
        {
            DFS(i, data, path);
        }
    }
}
*/