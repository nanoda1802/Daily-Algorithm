namespace Daily_Algorithm._2025_09.day0921;

// [문제 설명] 삼각형의 완성조건 1
// https://school.programmers.co.kr/learn/courses/30/lessons/120889

public class No08
{
    public int solution(int[] sides) {
        Array.Sort(sides);
        return sides[0] + sides[1] > sides[2] ? 1 : 2;
    }
}