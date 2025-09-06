namespace Daily_Algorithm._2025_09.day0906;

// [문제 설명] 수 조작하기 1
// https://school.programmers.co.kr/learn/courses/30/lessons/181926

public class No07
{
    public int Print(int n, string control) {
        
        int answer = n;
        
        foreach (char c in control)
        {
            switch (c)
            {
                case 'w': answer += 1; break;
                case 's': answer -= 1; break;
                case 'd': answer += 10; break;
                case 'a': answer -= 10; break;
            }
        }
        
        return answer;
    }
}