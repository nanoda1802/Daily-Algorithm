namespace Daily_Algorithm._2025_10.day1009;

// [문제 설명] 이상한 문자 만들기
// https://school.programmers.co.kr/learn/courses/30/lessons/12930

public class No01
{
    public string solution(string s) {
        // 'A' 65 , 'a' 97
        
        string answer = "";

        string[] strings = s.Split(' ');

        string temp;
        
        for (int i = 0; i < strings.Length; i++)
        {
            temp = "";

            for (int j = 0; j < strings[i].Length; j++)
            {
                string str = strings[i][j] + "";
                temp += j % 2 == 0 ? str.ToUpper() : str.ToLower();
            }

            answer += temp + " ";
        }
        
        return answer.Remove(answer.Length-1);
    }
}

// [다른풀이1 - 굳이 split 없이]  공백 기준으로 초기화해주고, 번갈아 짝-홀-짝-홀-...
/*
    using System.Text;
    
    public class Solution
    {
        public string solution(string s)
        {
            StringBuilder sb = new StringBuilder();
            bool isUpper = true;
    
            foreach (var ch in s)
            {
                if (' ' == ch)
                {
                    sb.Append(ch);
                    isUpper = true;
                    continue;
                }
    
                sb.Append(isUpper ? char.ToUpper(ch) : char.ToLower(ch));
                isUpper = !isUpper;
            }
    
            return sb.ToString();
        }
    }
*/