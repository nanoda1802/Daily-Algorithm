namespace Daily_Algorithm._2025_09.day0929;

// [문제 설명] 숨어있는 숫자 덧셈 2
// https://school.programmers.co.kr/learn/courses/30/lessons/120864

public class No06
{
    public int solution(string my_string)
    {
        // 'A' 65~90
        // 'a' 97~122

        char[] myChars = my_string.ToCharArray();
        
        string numStr = "";
        int answer = 0;

        for (int i = 0; i < myChars.Length; i++)
        {
            numStr += (myChars[i] >= 65 && myChars[i] <= 122) ? ' ' : myChars[i];
        }

        string[] nums = numStr.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string num in nums)
        {
            answer += int.Parse(num);
        }
        
        return answer;
    }
}