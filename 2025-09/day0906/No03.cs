namespace Daily_Algorithm._2025_09.day0906;

// [문제 설명] 주사위 게임2
// https://school.programmers.co.kr/learn/courses/30/lessons/181930

using System.Linq;

public class No03
{
    public int Print(int a, int b, int c) {
        int[] nums = { a, b, c };
        
        int answer = 0;

        int duplicates = nums.Distinct().Count();

        if (duplicates <= 1)
        {
            answer = nums.Sum() * nums.Sum(n=> n*n) * nums.Sum(n => n*n*n);
        } 
        else if (duplicates == 2)
        {
            answer = nums.Sum() * nums.Sum(n=> n*n);
        }
        else
        {
            answer = nums.Sum();
        }
        
        return answer;
    }
}

