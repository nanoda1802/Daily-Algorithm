namespace Daily_Algorithm._2025_10.day1005;

// [문제 설명] 정수 내림차순으로 배치하기
// https://school.programmers.co.kr/learn/courses/30/lessons/12933

public class No07
{
    public long solution(long n)
    {
        long answer = 0;
        long[] nums = new long[(long)Math.Floor(Math.Log10(n)+1)];

        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = n % 10;
            n /= 10;
        }
        
        Array.Sort(nums);
        answer += nums[0];
        
        for (int i = 1; i < nums.Length; i++)
        {
            int ten = 1;
            
            for (int j = 0; j < i; j++)
            {
                ten *= 10;
            }
            
            answer += nums[i] * ten;
        }
        
        return answer;
    }
}

// [메모] 여기는 string 전환이 나았을지도...