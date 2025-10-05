namespace Daily_Algorithm._2025_10.day1005;

// [문제 설명] 약수의 합
// https://school.programmers.co.kr/learn/courses/30/lessons/12928

public class No06
{
    public int solution(int n) {
        int answer = 0;

        List<int> nums = new List<int>();

        for (int i = 1; i*i <= n; i++)
        {
            if (n%i==0) nums.Add(i);
        }

        foreach (int num in nums)
        {
            if (num * num == n) answer += num;
            else answer += num + n / num;
        }
        
        return answer;
    }
}
// [메모] 어차피 또 반복 돌거면 그냥 끝까지 돌면서 더했으면 됐겄어... 