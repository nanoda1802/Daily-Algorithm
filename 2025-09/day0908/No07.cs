namespace Daily_Algorithm._2025_09.day0908;

// [문제 설명] 문자열 뒤집기
// https://school.programmers.co.kr/learn/courses/30/lessons/181905

public class No07
{
    public string Print(string my_string, int s, int e) {
        string answer = "";

        char[] myChars = my_string.ToCharArray();
        char prev;
        char next;

        for (int i = s; i <= s + (e-s)/2; i++)
        {
            prev = myChars[i];
            next = myChars[s + e - i];
            
            myChars[i] = next;
            myChars[s + e - i] = prev;
        }

        for (int i = 0; i < myChars.Length; i++)
        {
            answer += myChars[i];
        }

        return answer;
    }
}

// [다른풀이1 - Array 메서드]
// Array.Reverse(myChars,s,e-s+1);