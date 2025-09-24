namespace Daily_Algorithm._2025_09.day0924;

// [문제 설명] 가위바위보
// https://school.programmers.co.kr/learn/courses/30/lessons/120839

public class No01
{
    public string solution(string rsp) {
        // 2 -> 0
        // 0 -> 5
        // 5 -> 2
        
        string answer = "";

        for (int i = 0; i < rsp.Length; i++)
        {
            answer += rsp[i] switch
            {
                '2' => '0',
                '0' => '5',
                '5' => '2',
                _ => ""
            };
        }
        
        return answer;
    }
}