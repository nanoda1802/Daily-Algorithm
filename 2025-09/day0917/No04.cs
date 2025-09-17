namespace Daily_Algorithm._2025_09.day0917;

// [문제 설명] 특별한 이차원 배열 1
// https://school.programmers.co.kr/learn/courses/30/lessons/181833

public class No04
{
    public int[,] Print(int n)
    {
        // 행값 열값이 같으면 1, 아니면 0
        
        int[,] answer = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                answer[i,j] = i==j ? 1 : 0;
            }
        }
        
        return answer;
    }
}

// [다른풀이1 - int[] 요소의 기본값은 0]
/*
    int[,] answer = new int[n, n];
    
    for(int i = 0; i < n; ++i)  -> 1 인 위치만 갱신해주면 된다... (떠올려놓고 왜 못 쓴 겨)
        answer[i, i] = 1;
    
    return answer;
*/