namespace Daily_Algorithm._2025_10.day1010;

// [문제 설명] 푸드 파이트 대회
// https://school.programmers.co.kr/learn/courses/30/lessons/134240

using System.Text;

public class No03
{
    public string solution(int[] food) {
        // 물은 한개 : food[0]은 항상 1
        // 칼로리가 적을 수록 앞
        // 요소가 홀수면 1 빼서 짝수로
        // 인덱스를 요소 수만큼 배치
        // 가운데에 0 배치
        // 뒤집어서 또 배치

        StringBuilder sb = new StringBuilder();
        sb.Append(0);
        
        for (int i = food.Length-1; i >= 1; i--)
        {
            if (food[i]<=1) continue;
            
            int cnt = (food[i] - 2) / 2 + 1;

            for (int j = 0; j < cnt; j++)
            {
                sb.Append(i);
                sb.Insert(0, i);
            }
        }
        
        return sb.ToString();
    }
}

// [메모] 그냥 food[i] / 2 했으면 알아서 다 됐겄어...
// 1일 때도 알아서 0 되고,,, 홀수여도 알아서 몫만 딱 남고... ㅠㅠㅠ
