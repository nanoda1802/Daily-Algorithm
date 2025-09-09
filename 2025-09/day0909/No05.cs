namespace Daily_Algorithm._2025_09.day0909;

// [문제 설명] 첫번째로 나오는 음수
// https://school.programmers.co.kr/learn/courses/30/lessons/181896

public class No05
{
    public int Print(int[] num_list) {
        int answer = -1;

        for (int i = 0; i < num_list.Length; i++)
        {
            if (num_list[i] < 0)
            {
                answer = i;
                break;
            }
        }        
        
        return answer;
    }
}

// [다른풀이1 - Array 메서드]
// Array.FindIndex(num_list, f => f < 0);
// 배열, Predicate