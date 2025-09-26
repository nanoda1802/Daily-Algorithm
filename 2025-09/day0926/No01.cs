namespace Daily_Algorithm._2025_09.day0926;

// [문제 설명] 컨트롤 제트
// https://school.programmers.co.kr/learn/courses/30/lessons/120853

public class No01
{
    public int solution(string s)
    {
        int answer = 0;

        string[] chars = s.Split(" ");

        int recentNum = 0;

        for (int i = 0; i < chars.Length; i++)
        {
            if (chars[i].Equals("Z"))
            {
                answer -= recentNum;
                continue;
            }

            if (int.TryParse(chars[i], out int result))
            {
                answer += result;
                recentNum = result;
            }
        }
        
        return answer;
    }
}

// [다른풀이1 - 미리 빼두기] -> 미리 Z와 Z 앞 숫자를 제거해둠
/*
    int answer = 0;
    var list = s.Split(' ').ToList();
    
    while (list.Contains("Z"))
    {
        list.RemoveRange(list.IndexOf("Z") - 1, 2);
    }
    
    answer = list.Sum(x => Convert.ToInt32(x));
    
    return answer;
*/