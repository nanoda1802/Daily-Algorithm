namespace Daily_Algorithm._2025_09.day0927;

// [문제 설명] 인덱스 바꾸기
// https://school.programmers.co.kr/learn/courses/30/lessons/120895

public class No05
{
    public string solution(string my_string, int num1, int num2) {
        string answer = "";

        char[] myChars = my_string.ToCharArray();
        char temp;

        temp = myChars[num1];
        myChars[num1] = myChars[num2];
        myChars[num2] = temp;

        for (int i = 0; i < myChars.Length; i++)
        {
            answer += myChars[i];
        }
        
        return answer;
    }
}