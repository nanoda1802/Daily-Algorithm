namespace Daily_Algorithm._2025_10.day1022;

// [문제 설명] 체육복
// https://school.programmers.co.kr/learn/courses/30/lessons/42862

public class No02
{
    public int solution(int n, int[] lost, int[] reserve)
    {
        int answer = 0;
        
        int[] uniforms = new int[n+2];
        uniforms[0] = uniforms[uniforms.Length - 1] = -100;
        
        for (int i = 1; i <= n; i++)
        {
            uniforms[i] = 1;
            
            if (Array.Exists(reserve,e=>e==i)) uniforms[i] += 1;
            if (Array.Exists(lost,e=>e==i)) uniforms[i] -= 1;
        }

        for (int i = 1; i <= n; i++)
        {
            if (uniforms[i] == 2)
            {
                uniforms[i] -= 1;
                
                if (uniforms[i - 1] == 0)
                {
                    uniforms[i - 1] += 1;
                } 
                else if (uniforms[i + 1] == 0)
                {
                    uniforms[i + 1] += 1;
                }
            }
        }

        for (int i = 1; i <= n; i++)
        {
            answer += uniforms[i];
        }
        
        return answer;
    }
}

