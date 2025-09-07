namespace Daily_Algorithm._2025_09.day0907;

// [문제 설명] 콜라츠 수열
// https://school.programmers.co.kr/learn/courses/30/lessons/181919

using System.Collections.Generic;

public class No04
{
    public int[] Print(int n) {
        List<int> nums = new List<int>();
        int currentNum = n;
        nums.Add(currentNum);

        while (currentNum > 1)
        {
            if (isEven(currentNum))
            {
                currentNum /= 2;
            }
            else
            {
                currentNum = currentNum * 3 + 1;
            }
            
            nums.Add(currentNum);
        }

        return nums.ToArray();
    }

    private bool isEven(int num)
    {
        return num % 2 == 0;
    }
}