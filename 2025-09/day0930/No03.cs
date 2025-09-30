namespace Daily_Algorithm._2025_09.day0930;

// [문제 설명] 외계어 사전
// https://school.programmers.co.kr/learn/courses/30/lessons/120869

public class No03
{
    public  int solution(string[] spell, string[] dic) {
        int answer = 2;
        bool isExist = true;
        
        foreach (string word in dic)
        {
            isExist = true;
            
            foreach (string s in spell)
            {
                if (!word.Contains(s) || word.IndexOf(s) != word.LastIndexOf(s))
                {
                    isExist = false;
                    break;
                }
            }

            if (isExist)
            {
                answer = 1;
                break;
            }
        }
        
        return answer;
    }
}