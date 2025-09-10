namespace Daily_Algorithm._2025_09.day0910;

// [문제 설명] 왼쪽 오른쪽
// https://school.programmers.co.kr/learn/courses/30/lessons/181890

public class No02
{
    public string[] Print(string[] str_list) {
        // u d l r
        // l이 먼저면 해당 기준 왼쪽 문자열들
        // r이 먼저면 해당 기준 오른쪽 문자열들
        // l,r이 없으면 빈 배열

        int rIndex = Array.FindIndex(str_list, s => s == "r");
        int lIndex = Array.FindIndex(str_list, s => s == "l");

        if (lIndex == -1 && rIndex == -1) return new string[] {};

        List<string> answer = new List<string>();
        
        if (lIndex != -1 && (rIndex == -1 || lIndex < rIndex)) {
            for (int i = 0; i < lIndex; i++) {
                answer.Add(str_list[i]);
            }
        }
        
        else if (rIndex != -1 && (lIndex == -1 || rIndex < lIndex)) {
            for (int i = rIndex + 1; i < str_list.Length; i++) {
                answer.Add(str_list[i]);
            }
        }

        return answer.ToArray();
    }
}

// [다른풀이1 - 조건식 활용] 
/*
    List<string> list = new List<string>();
    
    int l = Array.IndexOf(str_list, "l");
    int r = Array.IndexOf(str_list, "r");
    
    if(l == -1)
        l = int.MaxValue; <- 히트
    if(r == -1)
        r = int.MaxValue; <- 히트
    
    if (l < r)
    {
        for (int i = 0; i < l; i++)
        {
            list.Add(str_list[i]);
        }
    }
    else if (l > r)
    {
        for (int i = r + 1; i < str_list.Length; i++)
        {
            list.Add(str_list[i]);
        }
    }
    
    return list.ToArray();
*/