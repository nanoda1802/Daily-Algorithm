namespace Daily_Algorithm._2025_09.day0912;

// [문제 설명] 특정 문자 대문자로 바꾸기
// https://school.programmers.co.kr/learn/courses/30/lessons/181873

using System.Text;

public class No05
{
    public string Print(string my_string, string alp) {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < my_string.Length; i++)
        {
            char c = my_string[i] == alp[0] ? (char) (my_string[i] - 32) : my_string[i];
            sb.Append(c);
            
        }

        return sb.ToString();
    }
}

// [다른풀이1 - String 메서드] <- replace를 잊고 있었다...
// return my_string.Replace(alp, alp.ToUpper()); 