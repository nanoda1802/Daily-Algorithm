namespace Daily_Algorithm._2025_09.day0921;

// [문제 설명] 문자 반복 출력
// https://school.programmers.co.kr/learn/courses/30/lessons/120825

using System.Text;

public class No05
{
    public  string solution(string my_string, int n)
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < my_string.Length; i++)
        {
            for (int j = 0; j < n; j++)
            {
                sb.Append(my_string[i]);
            }
        }
        
        return sb.ToString();
    }
}

// [다른풀이1 - append 반복 횟수 지정] -> 두번째 인자가 repeat count
// sb.Append(s, n) 

// [다른풀이2 - new String()] -> 두번째 인자가 count
// answer += new string(c, n);