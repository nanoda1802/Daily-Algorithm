namespace Daily_Algorithm._2025_09.day0908;

// [문제 설명] 문자열 정수의 합
// https://school.programmers.co.kr/learn/courses/30/lessons/181949

public class No10
{
    public int Print(string num_str) {
        int answer = 0;

        foreach (char c in num_str)
        {
            answer += int.Parse(c.ToString());
        }
        
        return answer;
    }
}

// [메모] char '0'을 빼는 원리
// '0'의 아스키 값은 정수 48이고, 순차적으로 '1'은 49처럼 1씩 늘어남
// 그래서 숫자형태의 char 변수에 '0'을 빼주면 해당 숫자를 int 타입으로 얻을 수 있는 것!!