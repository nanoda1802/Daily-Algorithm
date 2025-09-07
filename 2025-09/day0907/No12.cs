namespace Daily_Algorithm._2025_09.day0907;

// [문제 설명] I로 만들기
// https://school.programmers.co.kr/learn/courses/30/lessons/181934

public class No12
{
    public string Print(string myString)
    {
        char[] myChars = myString.ToCharArray();
        string answer = "";
        
        for (int i = 0; i < myChars.Length; i++)
        {
            answer += myChars[i] < 'l' ? 'l' : myChars[i];
        }

        return answer;
    }
}
