namespace Daily_Algorithm._2025_09.day0918;

// [문제 설명] 이차원 배열 대각선 순회하기
// https://school.programmers.co.kr/learn/courses/30/lessons/181829

public class No02
{
    public int Print(int[,] board, int k) {
        int answer = 0;

        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                if (i + j <= k) answer += board[i, j];
            }
        }
        
        return answer;
    }
}