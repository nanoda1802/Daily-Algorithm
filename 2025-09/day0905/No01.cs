namespace Daily_Algorithm._2025_09.day0905;

// [문제 설명] 문자열 섞기
// https://school.programmers.co.kr/learn/courses/30/lessons/181942

public class No01
{
    public string Print(string str1, string str2) {
        string answer = "";

        for (int i = 0; i < str1.Length; i++)
        {
            answer += str1[i].ToString() + str2[i];
        }
        
        return answer;
    }
}

// [다른풀이1]
// StringBuilder의 Append()