namespace Daily_Algorithm._2025_09.day0927;

// [문제 설명] 한 번만 등장한 문자
// https://school.programmers.co.kr/learn/courses/30/lessons/120896

public class No06
{
    public string solution(string s) {
        string answer = "";
        
        char[] chars = s.GroupBy(c => c).Where(g => g.Count() == 1).Select(g => g.Key).ToArray();
        Array.Sort(chars);
        answer = String.Concat(chars);
        
        return answer;
    }
}

// [다른풀이1 - 쪼갠 게 2면 유일한 글자!]
/*
    string answer = "";
    for(char ch = 'a'; ch <= 'z'; ++ch)
    {
        if(s.Split(ch).Length == 2)  // 여러 글자면 쪼개진 문자열이 여럿이겠징
        {
            answer += ch;
        }
    }
    return answer;
*/