namespace Daily_Algorithm._2025_10.day1016;

// [문제 설명] 소수 만들기
// https://school.programmers.co.kr/learn/courses/30/lessons/12977

public class No03
{
    public int solution(int[] nums)
    {
        // nums에 중복 숫자 X
        // 고르는 3 개도 서로 다르게
        
        // 홀 짝 짝
        // 홀 홀 홀
        
        int answer = 0;
        bool isPrime;
        
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i+1; j < nums.Length; j++)
            {
                for (int k = j+1; k < nums.Length; k++)
                {
                    isPrime = true;
                    int sum = nums[i] + nums[j] + nums[k];
                    
                    for (int l = 2; l*l <= sum; l++)
                    {
                        if (sum % l == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }

                    if (isPrime) answer += 1;
                }
            }
        }

        return answer;
    }
}
