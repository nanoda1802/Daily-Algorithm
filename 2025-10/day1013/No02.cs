namespace Daily_Algorithm._2025_10.day1013;

// [문제 설명] K번째 수
// https://school.programmers.co.kr/learn/courses/30/lessons/42748

public class No02
{
    public int[] solution(int[] array, int[,] commands) {
        int[] answer = new int[commands.GetLength(0)];
        
        int[] temp;

        for (int idx1 = 0; idx1 < commands.GetLength(0); idx1++)
        {
            (int i, int j, int k) = (commands[idx1, 0], commands[idx1, 1], commands[idx1, 2]);
            int len = j - i + 1;
            temp = new int[len];

            for (int idx2 = 0; idx2 < len; idx2++)
            {
                temp[idx2] = array[idx2 + i - 1];
            }
            
            Array.Sort(temp);

            answer[idx1] = temp[k - 1];
        }
        
        return answer;
    }
}
