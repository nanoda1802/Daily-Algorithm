namespace Daily_Algorithm._2025_10.day1014;

// [문제 설명] 명예의 전당 1
// https://school.programmers.co.kr/learn/courses/30/lessons/138477

public class No01
{
    public int[] solution(int k, int[] score) {
        // awards는 명전 점수들을 내림차순으로 보유
        // score[i]를 awards의 요소들과 비교
        // 적정 등수 위치에 삽입
        // 마지막 요소 answer에 투입

        List<int> award = new List<int>();
        int[] answer = new int[score.Length];

        for (int i = 0; i < score.Length; i++)
        {
            award.Add(score[i]);
            award.Sort((e1,e2)=>e2-e1);

            int idx = i < k ? award.Count - 1 : k - 1;
            answer[i] = award[idx];
        }

        return answer;
    }
}
