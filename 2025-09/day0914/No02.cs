namespace Daily_Algorithm._2025_09.day0914;

// [문제 설명] 배열의 원소만큼 추가하기
// https://school.programmers.co.kr/learn/courses/30/lessons/181861

public class No02
{
    public int[] Print(int[] arr)
    {
        List<int> answer = new List<int>();

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr[i]; j++)
            {
                answer.Add(arr[i]);
            }
        }
        
        return answer.ToArray();
    }
}
