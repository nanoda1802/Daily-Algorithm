namespace Daily_Algorithm._2025_09.day0907;

// [문제 설명] 배열 원소 삭제
// https://school.programmers.co.kr/learn/courses/30/lessons/181944

public class No13
{
    public int[] Print(int[] arr, int[] delete_list)
    {
        int size = arr.Length;

        foreach (int d in delete_list)
        {
            foreach (int i in arr)
            {
                if (i != d) continue; 
                size -= 1;
            }
        }
        
        int[] answer = new int[size];
        int idx = 0;
        bool isDuplicate = true;
        
        
        for (int i = 0; i < arr.Length; i++)
        {
            foreach (int d in delete_list)
            {
                if (arr[i] == d)
                {
                    isDuplicate = true;
                    break;
                }

                isDuplicate = false;
            }
            
            if (!isDuplicate) answer[idx++] = arr[i];
        }

        return answer;
    }
}

// [다른풀이1 - Linq]
// return arr.Except(delete_list).ToArray();
