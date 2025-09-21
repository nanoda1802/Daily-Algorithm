namespace Daily_Algorithm._2025_09.day0921;

// [문제 설명] 점의 위치 구하기
// https://school.programmers.co.kr/learn/courses/30/lessons/120841

public class No11
{
    public int solution(int[] dot) {
        if (dot[0] < 0) return dot[1] > 0 ? 2 : 3;
        if (dot[0] > 0) return dot[1] > 0 ? 1 : 4;
        
        return 0;
    }
}