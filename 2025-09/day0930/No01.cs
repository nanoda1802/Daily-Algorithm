namespace Daily_Algorithm._2025_09.day0930;

// [문제 설명] 안전지대
// https://school.programmers.co.kr/learn/courses/30/lessons/120866

public class No01
{
    public int solution(int[,] board)
    {
        int rowLen = board.GetLength(0);
        int columnLen = board.GetLength(1);
        
        int[,] check = new int[rowLen,columnLen];

        for (int i = 0; i < rowLen; i++)
        {
            for (int j = 0; j < columnLen; j++)
            {
                if (board[i,j] == 1)
                {
                    if (i + 1 < rowLen)
                    {
                        check[i + 1, j] = 1;
                        if (j-1 >= 0) check[i + 1, j - 1] = 1;
                        if (j+1 < columnLen) check[i + 1, j + 1] = 1;
                    }

                    if (i - 1 >= 0)
                    {
                        check[i - 1, j] = 1;
                        if (j-1 >= 0) check[i - 1, j - 1] = 1;
                        if (j+1 < columnLen) check[i - 1, j + 1] = 1;
                    }

                    check[i, j] = 1;
                    if (j-1 >= 0) check[i, j - 1] = 1;
                    if (j+1 < columnLen) check[i, j + 1] = 1;
                }
            }
        }
        
        int answer = 0;

        foreach (int c in check)
        {
            if (c == 0) answer += 1;
        }
        
        return answer;
    }
}