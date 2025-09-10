namespace Daily_Algorithm._2025_09.day0910;

// [문제 설명] 순서 바꾸기
// https://school.programmers.co.kr/learn/courses/30/lessons/181891

public class No01
{
    public int[] Print(int[] num_list, int n) {
        // A : n 이후 원소 배열, length - n
        // B : n 까지 원소 배열, n
        // A -> B 순서 배열 반환
        
        int prevLength = n;
        int nextLength = num_list.Length - n;
        
        int[] answer = new int[num_list.Length];

        for (int i = 0; i < prevLength; i++)
        {
            answer[nextLength + i] = num_list[i];
        }

        for (int i = 0; i < nextLength; i++)
        {
            answer[i] = num_list[prevLength + i];
        }

        return answer;
    }
}

// [다른풀이1 - Queue] <- 뒤에 껄 앞에 넣는 거니까!
/*
    Queue<int> q = new Queue<int>();
    
    for(int i = 0;i < num_list.Length;i++)
    {
        q.Enqueue(num_list[i]);
    }
    
    for(int i = 0;i < n;i++)
    {
        int x = q.Dequeue();
        q.Enqueue(x);
    }
    
    return q.ToArray();
*/