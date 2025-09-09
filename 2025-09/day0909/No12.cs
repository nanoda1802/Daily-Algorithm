namespace Daily_Algorithm._2025_09.day0909;

// [문제 설명] 뒤에서 5등 위로
// https://school.programmers.co.kr/learn/courses/30/lessons/181852

public class No12
{
    public int[] Print(int[] num_list) {
        int[] answer = new int[num_list.Length - 5];
        
        Sort(ref num_list);

        for (int i = 5; i < num_list.Length; i++)
        {
            answer[i-5] = num_list[i];
        }

        return answer;
    }

    private void Sort(ref int[] arr)
    {
        int prev = 0;
        int next = 0;
        
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 0; j < arr.Length - 1 - i; j++)
            {
                prev = arr[j];  
                next = arr[j+1];
                
                if (prev > next)
                {
                    arr[j] = next;
                    arr[j+1] = prev;
                }
            }
        }
    }
}