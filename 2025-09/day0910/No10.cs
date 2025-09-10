namespace Daily_Algorithm._2025_09.day0910;

// [문제 설명] 꼬리 문자열
// https://school.programmers.co.kr/learn/courses/30/lessons/181841

public class No10
{
    public string Print(string[] str_list, string ex) {
        string answer = "";
        
        for (int i = 0; i < str_list.Length; i++) {
            if (str_list[i].Contains(ex)) continue;
            answer += str_list[i];
        }
        
        return answer;
    }
}