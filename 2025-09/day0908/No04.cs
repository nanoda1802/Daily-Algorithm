namespace Daily_Algorithm._2025_09.day0908;

// [문제 설명] 접미사 배열
// https://school.programmers.co.kr/learn/courses/30/lessons/181909

public class No04
{
    public string[] Print(string my_string)
    {
        string[] answer = new string[my_string.Length];
        
        string temp = my_string;

        for (int i = 0; i < my_string.Length; i++)
        {
            answer[i] = temp;
            temp = temp.Remove(0,1);
        }

        Sort(ref answer);
        
        return answer;
    }

    private void Sort(ref string[] arr)
    {
        string prev = string.Empty;
        string next = string.Empty;
        
        for (int i = 0; i < arr.Length - 1; i++)
        {

            for (int j = 0; j < arr.Length-1; j++)
            {
                prev = arr[j];  
                next = arr[j+1];
                
                if (prev.CompareTo(next) > 0)
                {
                    arr[j] = next;
                    arr[j+1] = prev;
                }
            }
        }
    }
}