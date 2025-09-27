namespace Daily_Algorithm._2025_09.day0927;

// [문제 설명] 영어가 싫어요
// https://school.programmers.co.kr/learn/courses/30/lessons/120894

public class No04
{
    public long solution(string numbers)
    {
        string[] nums = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

        for (int i = 0; i < nums.Length; i++)
        {
            numbers = numbers.Replace(nums[i], i+"");
        }
        
        return long.Parse(numbers);
    }
}