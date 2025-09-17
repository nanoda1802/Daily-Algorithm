namespace Daily_Algorithm._2025_09.day0917;

// [문제 설명] 특별한 이차원 배열 2
// https://school.programmers.co.kr/learn/courses/30/lessons/181831

public class No05
{
    public int Print(int[,] arr) {
        int answer = 1;

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (arr[i, j] != arr[j, i])
                {
                    answer = 0;
                    break;
                }
            }
        }
        
        return answer;
    }
}

// [다른풀이1]
// answer에 할당하고 break 할 필요 없이 그냥 return 바로 해도 됐당 