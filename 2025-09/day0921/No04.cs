namespace Daily_Algorithm._2025_09.day0921;

// [문제 설명] 짝수 홀수 개수
// https://school.programmers.co.kr/learn/courses/30/lessons/120824

public class No04
{
    public int[] solution(int[] num_list) {
        int[] answer = new int[2];

        int evenCount = 0;

        foreach (int i in num_list)
        {
            if (i % 2 == 0) evenCount += 1;
        }

        answer[0] = evenCount;
        answer[1] = num_list.Length - evenCount;
        
        return answer;
    }
}