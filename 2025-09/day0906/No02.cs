namespace Daily_Algorithm._2025_09.day0906;

// [문제 설명] 등차수열의 특정 항만 더하기
// https://school.programmers.co.kr/learn/courses/30/lessons/181931

public class No02
{
    public int Print(int a, int d, bool[] included)
    {
        int answer = 0;
        
        for (int i = 0; i < included.Length; i++)
        {
            answer += included[i] ?  a+d*i : 0; 
        }
        
        return answer;
    }
}

