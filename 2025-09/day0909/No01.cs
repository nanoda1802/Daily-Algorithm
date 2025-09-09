namespace Daily_Algorithm._2025_09.day0909;

// [문제 설명] 문자 개수 세기
// https://school.programmers.co.kr/learn/courses/30/lessons/181902

public class No01
{
    public int[] Print(string my_string) {
        // 'A' 65~90
        // 'a' 97~122
        int[] answer = new int[52];
        
        foreach (char c in my_string)
        {
            int i = c;
            
            if (i >= 65 && i <= 90) 
                answer[i - 65] += 1;
            else if (i >= 97 && i <= 122) 
                answer[i - 97 + 26] += 1;
        }

        return answer;
    }
}
