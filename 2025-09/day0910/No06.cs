namespace Daily_Algorithm._2025_09.day0910;

// [문제 설명] 5명씩
// https://school.programmers.co.kr/learn/courses/30/lessons/181886

public class No06
{
    public string[] Print(string[] names) {
        string[] answer = new string[(names.Length+5-1)/5];
        int idx = 0;
        
        for (int i = 0; i < names.Length; i += 5)
        {
            answer[idx++] = names[i];
        }

        return answer;
    }
}