namespace Daily_Algorithm._2025_09.day0907;

// [문제 설명] 배열 만들기
// https://school.programmers.co.kr/learn/courses/30/lessons/181921

using System.Collections.Generic;

public class No02
{
    public int[] Print(int l, int r) {
        List<int> answer = new List<int>();
        
        string tempString = string.Empty;

        int start = (l % 5 == 0) ? l : (l + (5 - l % 5));
        
        for (int i = start; i <= r; i += 5)
        {
            tempString = i + "";
            if (Check(tempString)) answer.Add(int.Parse(tempString));
        }
        
        return answer.Count == 0 ? new int[] {-1} : answer.ToArray();
    }

    private bool Check(string str)
    {
        foreach (char c in str)
        {
            if (!(c.Equals('5') || c.Equals('0'))) return false;
        }
        return true;
    }
}

// [메모] 이거 제일 빠른 건 비트 연산일 것 같다... 각 자리 수가 5 또는 0인지만 보면 되는 거라...
