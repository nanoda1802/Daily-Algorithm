namespace Daily_Algorithm._2025_09.day0908;

// [문제 설명] 접미사인지 확인
// https://school.programmers.co.kr/learn/courses/30/lessons/181908

public class No05
{
    public int Print(string my_string, string is_suffix) { 
        string[] suffixs = new string[my_string.Length];
        string suffix = my_string;
        
        for (int i = 0; i < my_string.Length; i++)
        {
            suffixs[i] = suffix;
            suffix = suffix.Remove(0, 1);
        }
        
        int answer = 0;

        foreach (string s in suffixs)
        {
            if (s == is_suffix)
            {
                answer = 1;
                break;
            }
        }
        
        return answer;
    }
}

// [다른풀이1 - String 메서드]
// return my_string.EndsWith(is_suffix) ? 1 : 0; <- 천재인가