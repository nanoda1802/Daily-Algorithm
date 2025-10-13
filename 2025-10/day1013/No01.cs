namespace Daily_Algorithm._2025_10.day1013;

// [문제 설명] 숫자 문자열과 영단어
// https://school.programmers.co.kr/learn/courses/30/lessons/81301

public class No01
{
    public int solution(string s)
    {
        int answer = 0;

        string[] words = { "zero","one","two", "three", "four", "five", "six", "seven", "eight", "nine" };

        for (int i = 0; i < words.Length; i++)
        {
            s = s.Replace(words[i], i+"");
        }

        int.TryParse(s, out answer);
        
        return answer;
    }
}
