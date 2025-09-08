namespace Daily_Algorithm._2025_09.day0908;

// [문제 설명] 세로 읽기
// https://school.programmers.co.kr/learn/courses/30/lessons/181904

public class No08
{
    public string Print(string my_string, int m, int c) {
        string answer = "";

        char[] myChars = my_string.ToCharArray();

        for (int i = 0; i < myChars.Length; i+=m)
        {
            answer += myChars[i + c - 1];
        }

        return answer;
    }
}
