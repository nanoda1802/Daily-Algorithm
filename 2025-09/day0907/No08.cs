namespace Daily_Algorithm._2025_09.day0907;

// [문제 설명] 글자 이어 붙여 문자열 만들기
// https://school.programmers.co.kr/learn/courses/30/lessons/181915

using System.Text;

public class No08
{
    public string Print(string my_string, int[] index_list) {
        StringBuilder builder = new StringBuilder();

        foreach (int i in index_list)
        {
            builder.Append(my_string[i]);
        }
        
        return builder.ToString();
    }
}