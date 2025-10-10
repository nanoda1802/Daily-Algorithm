namespace Daily_Algorithm._2025_10.day1010;

// [문제 설명] 시저 암호
// https://school.programmers.co.kr/learn/courses/30/lessons/12926

public class No01
{
    public string solution(string s, int n) {
        // 'A' 65~90
        // 'a' 97~122
        
        // 암호 = 65 + ((x - 65 + n) % 26)
        
        char[] chars = s.ToCharArray();

        for (int i = 0; i < chars.Length; i++)
        {
            char v = chars[i];

            if (v >= 65 && v <= 90)
            {
                chars[i] = (char) (65 + ((v - 65 + n) % 26));
            }
            else if (v >= 97 && v <= 122)
            {
                chars[i] = (char) (97 + ((v - 97 + n) % 26));
            }
        }
        
        return new string(chars);
    }
}

// [다른풀이1 - 암시적형변환] -> 굳이 65나 97 등 코드 수 알 필요 없었당
/*
    char[] temp = s.ToCharArray();
    for(int i = 0; i < s.Length; ++i)
    {
        if ( (temp[i] >= 'a' && temp[i] <= 'z')|| (temp[i] >= 'A' && temp[i] <= 'Z'))
        {
            if (char.IsUpper(temp[i]))   => 굳이 조건문을 두 번하는 이유가 뭐지
            {
                temp[i] = (char)((temp[i] + n - 'A') % 26 + 'A');
            }
            else
            {
                temp[i] = (char)((temp[i] + n - 'a') % 26 + 'a');
            }
        }
    }
    return new string(temp);
*/