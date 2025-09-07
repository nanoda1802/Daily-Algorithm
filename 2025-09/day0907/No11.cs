namespace Daily_Algorithm._2025_09.day0907;

// [문제 설명] 조건에 맞게 수열 변환 3
// https://school.programmers.co.kr/learn/courses/30/lessons/181935

public class No11
{
    public int[] Print(int[] arr, int k)
    {
        int[] answer = arr;

        if (k % 2 == 0)
        {
            for (int i = 0; i < answer.Length; i++)
            {
                answer[i] += k;
            }    
        }
        else
        {
            for (int i = 0; i < answer.Length; i++)
            {
                answer[i] *= k;
            }    
        }
        
        return answer;
    }
}
