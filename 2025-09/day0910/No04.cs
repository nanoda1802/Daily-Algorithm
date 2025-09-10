namespace Daily_Algorithm._2025_09.day0910;

// [문제 설명] n개 간격의 원소들
// https://school.programmers.co.kr/learn/courses/30/lessons/181888

public class No04
{
    public int[] Print(int[] num_list, int n)
    {
        int newLength = num_list.Length % n == 0 ? num_list.Length / n : num_list.Length / n + 1;
        
        int[] answer = new int[newLength];
        int idx = 0;
        
        for (int i = 0; i < num_list.Length; i+=n) answer[idx++] = num_list[i];
        
        return answer;
    }
}