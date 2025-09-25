namespace Daily_Algorithm._2025_09.day0925;

// [문제 설명] 문자열 정렬하기
// https://school.programmers.co.kr/learn/courses/30/lessons/120850

public class No04
{
    public int[] solution(string my_string)
    {
        List<int> answer = new List<int>(my_string.Length);

        foreach (char c in my_string)
        {
            if (Char.IsDigit(c)) answer.Add(c-'0');
        }
        
        answer.Sort();
        
        return answer.ToArray();
    }
}

// [다른풀이1 - TryParse] 변환 안 되면 안 넣음!! 
//  if (int.TryParse(c.ToString(), out var value)) answer.Add(value);
