namespace Daily_Algorithm._2025_09.day0907;

// [문제 설명] 배열 만들기 4
// https://school.programmers.co.kr/learn/courses/30/lessons/181918

using System.Collections.Generic;

public class No05
{
    public int[] Print(int[] arr) {
        List<int> stk = new List<int>();
        int i = 0;

        while (arr.Length > i)
        {
            if (stk.Count == 0 || stk[stk.Count - 1] < arr[i]) stk.Add(arr[i++]);
            else stk.RemoveAt(stk.Count - 1);
        }
        
        return stk.ToArray();
    }
}

// [다른풀이1 - Array 메서드]
// Array.Resize(stk, stk.Length+1); <- 매번 하는 거 좀 그렇긴 하쥬