namespace Daily_Algorithm._2025_09.day0908;

// [문제 설명] 문자열 뒤 n글자
// https://school.programmers.co.kr/learn/courses/30/lessons/181910

public class No03
{
    public string Print(string my_string, int n) {
        string answer = "";

        for (int i = my_string.Length-n; i < my_string.Length; i++)
        {
            answer += my_string[i];
        }

        return answer;
    }
}

// [다른풀이1 - String 메서드]
// return my_string.Remove(0,my_string.Length-n); <- 앞을 날리는 것도 방법이넹