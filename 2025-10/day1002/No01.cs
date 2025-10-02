namespace Daily_Algorithm._2025_10.day1002;

// [문제 설명] 등수 매기기
// https://school.programmers.co.kr/learn/courses/30/lessons/120882

public class No01
{
    public int[] solution(int[,] score) {
        int len = score.GetLength(0);

        int[] averages = new int[len];

        for (int i = 0; i < len; i++)
        {
            averages[i] = (score[i,0] + score[i,1]); // int 나눗셈이라 합이 홀수면 0.5가 날아가버림 => 어차피 모든 요소가 두개씩이니까 평균말고 합으로 랭킹
        }

        int[] ranks = new int[len];

        for (int i = 0; i < len; i++)
        {
            ranks[i] = 1; // 일단 1씩 넣어두고

            for (int j = 0; j < len; j++)
            {
                if (i == j) continue;

                if (averages[i] < averages[j]) ranks[i] += 1; // 만약 자기보다 큰 값이 있으면 등수 하나씩 밀기
            }
        }

        return ranks;
    }
}

// [메모] 