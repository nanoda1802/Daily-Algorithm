namespace Daily_Algorithm._2025_10.day1010;

// [문제 설명] 두 개 뽑아서 더하기
// https://school.programmers.co.kr/learn/courses/30/lessons/68644

public class No02
{
    private List<int> answer = new List<int>();
    private int[] nums;
    
    public int[] solution(int[] numbers)
    {
        nums = numbers;

        for (int i = 0; i < nums.Length-1; i++)
        {
            Oper(i);
        }
        
        answer.Sort();
        
        return answer.ToArray();
    }


    private void Oper(int curIdx = 0)
    {
        for (int i = curIdx + 1; i < nums.Length; i++)
        {
            int v = nums[curIdx] + nums[i];
            if (!answer.Contains(v)) answer.Add(v);
        }
    }
}