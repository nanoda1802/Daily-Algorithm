namespace Daily_Algorithm._2025_09.day0918;

// [문제 설명] 정수를 나선형으로 배치하기
// https://school.programmers.co.kr/learn/courses/30/lessons/181832

public class No03
{
    public int[,] Print(int n) {
        
        // n번 순회
        
        // 순회당 1차원 한번, 0차원 한번 채우기
        // 1차원은 i번 채웠으면, 0차원은 i-1번 채움
        
        // 같은 회차에 각 차원 채우는 방향은 동일 (순행/역행)
        // 첫 회차 순행 시작해 순행~역행~순행~역행~ 반복
        
        int[,] answer = new int[n, n];
        int num = 1;

        int stan;

        for (int i = 0; i < n; i++)
        {
            if (i % 2 == 0)
            {
                stan = i / 2;
                
                for (int j = stan; j < n - stan; j++)
                {
                    answer[stan, j] = num++;
                }

                for (int j = stan+1; j < n - stan; j++)
                {
                    answer[j, n - stan - 1] = num++;
                }    
            }
            else
            {
                stan = i / 2 + 1;
                for (int j = n-stan-1; j >= stan-1; j--)
                {
                    answer[n - stan, j] = num++;
                }
                for (int j = n-stan-1; j >= stan; j--)
                {
                    answer[j, stan - 1] = num++;
                }
            }
        }
        return answer;
    }
}

// [다른풀이]
// 날 잡고 찾아볼 만 하겠음...

// 짝수 회차 

// i = 0 (i/2 = 0)
// 0 / j = 0~6 (i/2 <= x < n-i/2)
// j = 1~6 / 6  (i/2+1 <= x < n-i/2)

// i = 2 (i/2 = 1)
// 1 / j = 1~5 (i/2 <= x < n-i/2)
// j = 2~5 / 5 (i/2+1 <= x < n-i/2)

// i = 4 (i/2 = 2)
// 2 / j = 2~4 (i/2 <= x < n-i/2)
// j = 3~4 / 4 (i/2+1 <= x < n-i/2)

// i = 6 (i/2 = 3)
// 3 / j = 3
// X

// 홀수 회차

// i = 1 (stan = i/2 + 1 = 1)
// 6 / j = 5~0 (n-stan / n-stan-1 >= x >= stan-1)
// j = 5~1 / 0 (n-stan-1 >= x >= stan / stan-1)

// i = 3 (stan = i/2 + 1 = 2)
// 5 / j = 4~1 (n-stan / n-stan-1 >= x >= stan-1)
// j = 4~2 / 1 (n-stan-1 >= x >= stan / stan-1)

// i = 5 (stan = i/2 + 1 = 3)
// 4 / j = 3~2 (n-stan / n-stan-1 >= x >= stan-1) 
// j = 3 / 2 (n-stan-1 >= x >= stan / stan-1)