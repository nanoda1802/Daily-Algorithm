namespace Daily_Algorithm._2025_09.day0912;

// [문제 설명] 배열에서 문자열 대소문자 변환하기
// https://school.programmers.co.kr/learn/courses/30/lessons/181875

public class No03
{
    public string[] Print(string[] strArr) {
        string[] answer = new string[strArr.Length];

        for (int i = 0; i < strArr.Length; i++)
        {
            if (i % 2 != 0) 
                answer[i] = strArr[i].ToUpper();
            else
                answer[i] = strArr[i].ToLower();
        }
        
        return answer;
    }
}