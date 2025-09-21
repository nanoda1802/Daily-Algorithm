namespace Daily_Algorithm._2025_09.day0921;

// [문제 설명] 아이스 아메리카노
// https://school.programmers.co.kr/learn/courses/30/lessons/120819

public class No02
{
    public int[] solution(int money) {
        int[] answer = new int[2];
        answer[0] = money / 5500;
        answer[1] = money % 5500;
        return answer;
    }
}