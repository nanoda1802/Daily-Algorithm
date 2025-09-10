namespace Daily_Algorithm._2025_09.day0910;

// [문제 설명] 홀수 vs 짝수
// https://school.programmers.co.kr/learn/courses/30/lessons/181887

public class No05
{
    public int Print(int[] num_list) {
        int evenSum = 0;
        int oddSum = 0;

        for (int i = 0; i < num_list.Length; i++)
        {
            if (i % 2 == 0)
            {
                oddSum += num_list[i];
            }
            else
            {
                evenSum += num_list[i];
            }
        }
        
        return evenSum > oddSum ? evenSum : oddSum;
    }
}