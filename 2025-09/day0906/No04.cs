namespace Daily_Algorithm._2025_09.day0906;

// [문제 설명] 원소들의 곱과 합
// https://school.programmers.co.kr/learn/courses/30/lessons/181929

using System.Linq;

public class No04
{
    public int Print(int[] num_list)
    {
        int mult = num_list.Aggregate((acc, cur) => acc * cur);
        int sum = num_list.Sum();
        
        return mult < sum*sum ? 1 : 0;
    }
}

// [다른풀이1 - 근본]
/*
    int add = 0;
    int mult = 1;

    for(int i = 0; i < num_list.Length; i++)
    {
        Add += num_list[i];
        mult *= num_list[i];
    }

    if((Add * Add) > mult) return 1;
    
    return 0;
*/