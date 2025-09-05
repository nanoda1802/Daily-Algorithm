namespace Daily_Algorithm._2025_09.day0905;

// [문제 설명] 문자 리스트를 문자열로 변환
// https://school.programmers.co.kr/learn/courses/30/lessons/181941

public class No02
{
    public string Print(string[] arr) {
        string answer = "";
        
        foreach (string s in arr)
        {
            answer += s;
        }
        
        return answer;
    }
}

// [다른풀이1]
// String.Join("", arr)

// [다른풀이2]
// string.Concat(arr)