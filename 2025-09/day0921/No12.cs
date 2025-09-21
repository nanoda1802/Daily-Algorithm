namespace Daily_Algorithm._2025_09.day0921;

// [문제 설명] n의 배수 고르기
// https://school.programmers.co.kr/learn/courses/30/lessons/120905

public class No12
{
    public int[] solution(int n, int[] numlist)
    {
        List<int> answer = new List<int>();

        for (int i = 0; i < numlist.Length; i++)
        {
            if (numlist[i] % n == 0) answer.Add(numlist[i]);
        }
        
        return answer.ToArray();
    }
}