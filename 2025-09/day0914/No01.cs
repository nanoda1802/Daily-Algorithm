namespace Daily_Algorithm._2025_09.day0914;

// [문제 설명] 세 개의 구분자
// https://school.programmers.co.kr/learn/courses/30/lessons/181862

public class No01
{
    public string[] Print(string myStr) {
        // 구분자 : a b c
        // 구분자 사이에 다른 문자 없으면 저장 X
        // 빈 배열이면 { "EMPTY" } 리턴

        string[] answer = myStr.Replace('a', '/').Replace('b', '/').Replace('c', '/').Replace("/", " ").Split(" ",StringSplitOptions.TrimEntries);
        
        return answer.Length != 0 ? answer : new string[] { "EMPTY" };
    }

    // [제출버전]
    public string[] Printt(string myStr)
    {
        List<string> answer = new List<string>(myStr.Length);
        string[] temp = myStr.Replace('a', '/').Replace('b', '/').Replace('c', '/').Replace("/", " ").Split(" ");

        for (int i = 0; i < temp.Length; i++)
        {
            if (string.IsNullOrWhiteSpace(temp[i])) continue;
            
            answer.Add(temp[i]); 
        }
        
        return answer.Count != 0 ? answer.ToArray() : new string[] { "EMPTY" };
    }
}

// [다른풀이 1 - 오버로드된 split]
/*
    char[] separators = new char[3]{ 'a', 'b', 'c' };
    string[] answer = myStr.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    return answer.Length == 0 ? new string[1]{ "EMPTY" } : answer; 
*/