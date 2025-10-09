namespace Daily_Algorithm._2025_10.day1009;

// [문제 설명] 가장 가까운 같은 글자
// https://school.programmers.co.kr/learn/courses/30/lessons/142086

public class No03
{
    public int[] solution(string s)
    {
        int[] answer = new int[s.Length];
        Dictionary<char, int> spells = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            
            if (spells.TryAdd(c,i))
            {
                answer[i] = -1;
            }
            else
            {
                answer[i] = i - spells[c];
                spells[c] = i;
            }
        }
        
        return answer;
    }
}

// [다른풀이1 - Substring 활용] -> 현재 글자 앞 부분 중 (Substring) 가장 마지막에 있는 같은 글자 위치 확인! (LastIndexOf)
/*
    int[] answer = new int[s.Length];
    answer[0] = -1;
    
    for (int i = 1; i < s.Length; i++)
    {
        int idx = s.Substring(0, i).LastIndexOf(s[i]); 
    
        answer[i] = idx == -1 ? -1 : i - s.Substring(0, i).LastIndexOf(s[i]);
    }
    
    return answer;
*/