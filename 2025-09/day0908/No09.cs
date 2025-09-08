namespace Daily_Algorithm._2025_09.day0908;

// [문제 설명] QR Code
// https://school.programmers.co.kr/learn/courses/30/lessons/181903

public class No09
{
    public string Print(int q, int r, string code) {
        string answer = "";

        for (int i = r; i < code.Length; i+=q)
        {
            answer += code[i];
        }

        return answer;
    }
}

// [메모] 인덱스를 q로 나눴을 때 나머지라 r이다 => ( (i + r) / q == 0 ) 