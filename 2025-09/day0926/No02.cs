namespace Daily_Algorithm._2025_09.day0926;

// [문제 설명] 중복 문자 제거
// https://school.programmers.co.kr/learn/courses/30/lessons/120888

public class No02
{
    public string solution(string my_string) {
        string answer = "";

        for (int i = 0; i < my_string.Length; i++)
        {
            int firstIdx = my_string.IndexOf(my_string[i]);
            int lastIdx = my_string.LastIndexOf(my_string[i]);
            
            if (firstIdx != lastIdx && firstIdx != i) continue;
            
            answer += my_string[i];
        }
        
        return answer;
    }
}

// [다른풀이1 - 합칠 곳에서 확인] -> 어차피 answer에 모으니까 answer에서 Contains하면 됐네...
/*
    string answer = "";
    for(int i=0;i<my_string.Length;i++)
    {
        if(!answer.Contains(my_string[i]))
        {
            answer+=my_string[i];
        }
    }
    return answer;
*/