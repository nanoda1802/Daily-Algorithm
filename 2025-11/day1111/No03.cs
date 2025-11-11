namespace Daily_Algorithm._2025_11.day1111;
// 숫자 변환하기
// https://school.programmers.co.kr/learn/courses/30/lessons/154538

// 가능한 연산 : +n / *2 / *3
// x를 y로 변환하기 위한 최소 연산 횟수 return
// 불가능하면 -1 return

// 1 <= x <= y <= 1,000,000
// 1 <= n < y

public class No03
{
    public int solution(int x, int y, int n) {
        // x=y 면 return 0
        // y/x의 몫 quotient
        // quotient >= 3 이면 "*3" 연산으로
        // quotient = 2 면 "*2" 연산으로
        // 둘다 아니면 "+n" 연산으로
        
        // BFS...? <- 맞음!
        
        Queue<(int,int)> oper = new Queue<(int,int)>();
        HashSet<int> visited = new HashSet<int>();
        oper.Enqueue((x,0));
        
        while (oper.Count > 0)
        {
            (int cur, int count) = oper.Dequeue();
            
            if (cur == y) return count;    
            if (cur > y) continue;

            int addN = cur + n;
            int mul2 = cur * 2;
            int mul3 = cur * 3;

            if (!visited.Contains(addN))
            {
                oper.Enqueue((addN,count+1));
                visited.Add(addN);
            }

            if (!visited.Contains(mul2))
            {
                oper.Enqueue((mul2,count+1));
                visited.Add(mul2);
            }

            if (!visited.Contains(mul3))
            {
                oper.Enqueue((mul3,count+1));
                visited.Add(mul3);
            }
        }
        
        return -1;
    }

    // [개선 버전]
    public int solution2(int x, int y, int n) {
        bool[] visited = new bool[y + 1];
        Queue<(int,int)> op = new Queue<(int,int)>();
        op.Enqueue((y,0));
        
        while (op.Count > 0)
        {
            (int cur, int count) = op.Dequeue();
            
            if (cur == x) return count;    
            if (cur < x) continue;

            int subN = cur - n;
            int div2 = cur / 2;
            int div3 = cur / 3;

            if (subN>=x && !visited[subN])
            {
                op.Enqueue((subN,count+1));
                visited[subN] = true;
            }
            if (cur%2==0 && !visited[div2])
            {
                op.Enqueue((div2,count+1));
                visited[div2] = true;
            }
            if (cur%3==0 && !visited[div3])
            {
                op.Enqueue((div3,count+1));
                visited[div3] = true;
            }
        }
        
        return -1;
    }
}

// [메모]
// y보다 커지는 값은 어차피 신경쓰지 않으니
// bool[] visited = new bool[y + 1];
// 굳이 hashSet 말고 이렇게 하면 됐따...

// [메모]
// x에서 y로 상향식 진행을 할 경우, 3x, 2x, x+n 은 모두 정수가 되기 때문에, 따져봐야 할 경우의 수가 많습니다.
// 반면, y에서 x로 하향식 진행을 하면, y/3, y/2, y-n 은 적지않게 float가 되기 때문에, 정수일 때만 따져보면 되므로 가지치기 속도가 향상 될 수 있습니다!

