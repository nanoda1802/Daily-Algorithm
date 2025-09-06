namespace Daily_Algorithm._2025_09.day0906;

// [문제 설명] 마지막 두 원소
// https://school.programmers.co.kr/learn/courses/30/lessons/181927

public class No06
{
    public int[] Print(int[] num_list)
    {
        int last = num_list[num_list.Length - 1];
        int last2 = num_list[num_list.Length - 2];
        
        int[] answer = new int[num_list.Length+1];

        for (int i = 0; i < num_list.Length; i++)
        {
            answer[i] = num_list[i];
        }

        answer[answer.Length - 1] = last > last2 ? last - last2 : last * 2;
        
        return answer;
    }
}

// [다른풀이1 - Array 메서드]
// Array.Resize(ref num_list, num_list.Length + 1) <- ref를 통해 원본 배열의 길이 늘림

// [다른풀이1 - Array 메서드]
// int[] answer = new int[num_list.Length + 1]
// Array.Copy(num_list, answer, num_list.Length); <- 복사할배열, 붙여넣을배열, 복사할길이

