namespace Daily_Algorithm._2025_10.day1002;

// [문제 설명] 옹알이 1
// https://school.programmers.co.kr/learn/courses/30/lessons/120956

public class No03
{
    public int solution(string[] babbling)
    {
        string[] words = { "aya", "ye", "woo", "ma" };
        string temp = String.Empty;
        
        int answer = 0;

        for (int i = 0; i < babbling.Length; i++)
        {
            temp = babbling[i];
            
            foreach (string word in words)
            {
                temp = temp.Replace(word, "@");
            }

            temp = temp.Replace("@", "");
            
            if (temp.Length == 0) answer += 1;
        }
        
        return answer;
    }
}