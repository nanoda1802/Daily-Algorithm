namespace Daily_Algorithm._2025_09.day0905;

// [문제 설명] 문자열 곱하기
// https://school.programmers.co.kr/learn/courses/30/lessons/181940

public class No03
{
    public string Print(string my_string, int k) {
        string answer = "";
        
        for(int i =1;i <=k; i++) answer += my_string;

        return answer;
    }
}

// [다른풀이1-Linq]
// Enumerable.Range(0, k).Select(s => my_string).Aggregate((a, b) => a + b)

// [다른풀이2-Linq]
// String.Concat(Enumerable.Repeat(my_string, k))