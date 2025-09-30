namespace Daily_Algorithm._2025_09.day0929;

// [문제 설명] 잘라서 배열로 저장하기
// https://school.programmers.co.kr/learn/courses/30/lessons/120913

using System.Text;

public class No02
{
    public string[] solution(string my_str, int n) {
        string[] answer = new string[(my_str.Length-1)/n+1];
        int idx = 0;
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < my_str.Length; i+=n)
        {
            sb.Clear();
            
            for (int j = 0; j < n; j++)
            {
                if (i+j >= my_str.Length) break;
                
                sb.Append(my_str[i + j]);
            }

            answer[idx++] = sb.ToString();
        }
        
        return answer;
    }
}

// [다른풀이1 - Substring]