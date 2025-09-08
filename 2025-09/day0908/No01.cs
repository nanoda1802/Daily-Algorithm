namespace Daily_Algorithm._2025_09.day0908;

// [문제 설명] 배열 만들기 5
// https://school.programmers.co.kr/learn/courses/30/lessons/181912

using System.Collections.Generic;

public class No01
{
    public int[] Print(string[] intStrs, int k, int s, int l)
    {
        int temp = 0;
        List<int> answer = new List<int>();
        
        foreach (string el in intStrs)
        {
            temp = int.Parse(el.Substring(s, l));
            
            if (temp > k) answer.Add(temp);
        }
        
        return answer.ToArray();
    }
}
