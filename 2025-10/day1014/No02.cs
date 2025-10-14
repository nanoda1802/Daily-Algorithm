namespace Daily_Algorithm._2025_10.day1014;

// [문제 설명] 카드뭉치
// https://school.programmers.co.kr/learn/courses/30/lessons/159994

public class No02
{
    public string solution(string[] cards1, string[] cards2, string[] goal) {
        int idx1 = 0;
        int idx2 = 0;

        for (int i = 0; i < goal.Length; i++)
        {
            bool compare1 = goal[i].Equals(cards1[idx1]);
            bool compare2 = goal[i].Equals(cards2[idx2]);

            if (!(compare1 || compare2)) return "No";

            if (compare1) idx1 = Math.Clamp(idx1 + 1, 0, cards1.Length-1);
            else if (compare2) idx2 = Math.Clamp(idx2 + 1, 0, cards2.Length-1);
        }

        return "Yes";
    }
}
