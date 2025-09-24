namespace Daily_Algorithm._2025_09.day0924;

// [문제 설명] 배열 회전시키기
// https://school.programmers.co.kr/learn/courses/30/lessons/120844

public class No05
{
    public int[] solution(int[] numbers, string direction)
    {
        LinkedList<int> answer = new LinkedList<int>();

        for (int i = 0; i < numbers.Length; i++)
        {
            answer.AddLast(numbers[i]);
        }
        
        if (direction.StartsWith('r'))
        {
            int last = answer.Last.Value;
            answer.RemoveLast();
            answer.AddFirst(last);
        }
        else
        {
            int first = answer.First.Value;
            answer.RemoveFirst();
            answer.AddLast(first);
        }
        
        return answer.ToArray();
    }
}
