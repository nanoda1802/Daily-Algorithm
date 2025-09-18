namespace Daily_Algorithm._2025_09.day0918;

// [문제 설명] 정사각형으로 만들기
// https://school.programmers.co.kr/learn/courses/30/lessons/181830

public class No01
{
    public int[,]  Print(int[,] arr) {
        // 0차원길이 > 1차원길이 : 각 하위요소에 부족분만큼 0 추가
        // 0차원길이 < 1차원길이 : 1차원길이 만큼 0으로 채운 하위요소를 부족분만큼 추가

        int[,] answer = null;
        
        int rowLen = arr.GetLength(0);
        int columnLen = arr.GetLength(1);
        int differ = rowLen - columnLen;

        if (differ == 0)
        {
            answer = arr;
        }
        else if (differ > 0)
        {
            answer = new int[rowLen, rowLen];
            
            for (int i = 0; i < rowLen; i++)
            {
                for (int j = 0; j < columnLen; j++)
                {
                    answer[i, j] = arr[i, j];
                }
            }
        }
        else if (differ < 0)
        {
            answer = new int[columnLen, columnLen];

            for (int i = 0; i < rowLen; i++)
            {
                for (int j = 0; j < columnLen; j++)
                {
                    if (i < rowLen) answer[i, j] = arr[i, j];
                }
            }
        }

        return answer;
    }
}