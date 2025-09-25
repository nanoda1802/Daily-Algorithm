namespace Daily_Algorithm._2025_09.day0925;

// [문제 설명] 주사위의 개수
// https://school.programmers.co.kr/learn/courses/30/lessons/120845

public class No01
{
    public int solution(int[] box, int n)
    {
        if (box[0] < n || box[1] < n || box[2] < n) return 0;
        return (box[0] / n) * (box[1] / n) * (box[2] / n);
    }
}