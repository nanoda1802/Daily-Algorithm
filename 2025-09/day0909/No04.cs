namespace Daily_Algorithm._2025_09.day0909;

// [문제 설명] 리스트 자르기
// https://school.programmers.co.kr/learn/courses/30/lessons/181897

using System.Collections.Generic;

public class No04
{
    public int[] Print(int n, int[] slicer, int[] num_list) {
      switch (n)
        {
            case 1: return Slice(slicer[1],num_list,true);
            case 2: return Slice(slicer[0],num_list,false);
            case 3: return Slice(slicer[0], slicer[1] ,num_list);
            case 4: return Slice(slicer[0], slicer[1], slicer[2] ,num_list);
        }
        
        return null;
    }
    
    private int[] Slice(int n, int[] nums, bool isRightOrder)
    {
        List<int> answer = new List<int>();

        if (isRightOrder)
        {
            for (int i = 0; i <= n; i++)
            {
                answer.Add(nums[i]);
            }    
        }
        else
        {
            for (int i = n; i < nums.Length; i++)
            {
                answer.Add(nums[i]);
            }    
        }

        return answer.ToArray();
    }
    
    private int[] Slice(int a, int b, int[] nums)
    {
        List<int> answer = new List<int>();
        for (int i = a; i <= b; i++)
        {
            answer.Add(nums[i]);
        }
        
        return answer.ToArray();
    }
    
    private int[] Slice(int a, int b, int c, int[] nums)
    {
        List<int> answer = new List<int>();
        for (int i = a; i <= b; i += c)
        {
            answer.Add(nums[i]);
        }
        
        return answer.ToArray();
    }
}