namespace Daily_Algorithm._2025_10.day1022;

// [문제 설명] 숫자 짝꿍
// https://school.programmers.co.kr/learn/courses/30/lessons/131128

using System.Text;
public class No04
{
    public string solution(string X, string Y)
    {
        StringBuilder sb = new StringBuilder();
        
        int[] xNums = new int[10];
        foreach (char c in X) xNums[c - '0'] += 1;
        
        int[] yNums = new int[10];
        foreach (char c in Y) yNums[c - '0'] += 1;

        int[] inter = new int[10];
        int sum = 0;
        
        for (int i = 9; i >= 0; i--)
        {
            inter[i] = xNums[i] > yNums[i] ? yNums[i] : xNums[i];
            sum += inter[i];

            for (int j = 0; j < inter[i]; j++) sb.Append(i);
        }

        if (sum == 0) return "-1";
        if (sum == inter[0]) return "0";

        return sb.ToString();
    }
}

