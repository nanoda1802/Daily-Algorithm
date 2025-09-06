namespace Daily_Algorithm._2025_09.day0906;

// [문제 설명] 이어 붙인 수
// https://school.programmers.co.kr/learn/courses/30/lessons/181928

using System.Text;

public class No05
{
    public int Print(int[] num_list)
    {
        StringBuilder evenNum = new StringBuilder();
        StringBuilder oddNum = new StringBuilder();

        for (int i = 0; i < num_list.Length; i++)
        {
            int num = num_list[i];

            if (isEven(num))
                evenNum.Append(num);
            else
                oddNum.Append(num);
        }

        return int.Parse(evenNum.ToString()) + int.Parse(oddNum.ToString());
    }

    private bool isEven(int num)
    {
        return num % 2 == 0;
    }
}
