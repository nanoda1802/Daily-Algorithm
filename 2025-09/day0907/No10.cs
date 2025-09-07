namespace Daily_Algorithm._2025_09.day0907;

// [문제 설명] 문자열 여러 번 뒤집기
// https://school.programmers.co.kr/learn/courses/30/lessons/181913

public class No10
{
    public string Print(string my_string, int[,] queries) {
        int start = 0;
        int length = 0;
        string temp = "";
        string answer = my_string;
        
        
        for (int i = 0; i < queries.GetLength(0); i++)
        {
            start = queries[i,0];
            length = queries[i,1] - start + 1;
            temp = answer.Substring(start, length);
            
            answer = answer.Remove(start, length);

            answer = answer.Insert(start, Reverse(temp.ToCharArray()));
        }
        
        return answer;
    }

    private string Reverse(char[] str)
    {
        char front = 'a';
        char behind = 'a';
        string reversed = "";
        
        for (int i = 0; i < str.Length / 2; i++)
        {
            front = str[i];
            behind = str[str.Length - i - 1];
            
            str[i] = behind;
            str[str.Length - i - 1] = front;
        }

        foreach (char c in str)
        {
            reversed += c;
        }

        return reversed;
    }
}

// [다른풀이1 - Array.Reverse]
// Array.Reverse(answer.ToCharArray(), start, length) <- 어차피 char 배열로 바꿀 거였음 이렇게... 그래도 reverse 직접 구현 한잔혀