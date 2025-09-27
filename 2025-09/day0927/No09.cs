namespace Daily_Algorithm._2025_09.day0927;

// [문제 설명] 가장 큰 수 찾기
// https://school.programmers.co.kr/learn/courses/30/lessons/120899

public class No09
{
    public int[] solution(int[] array) {
        int[] answer = new int[2];

        answer[0] = array.Max();
        answer[1] = Array.IndexOf(array, answer[0]);
        
        return answer;
    }
}