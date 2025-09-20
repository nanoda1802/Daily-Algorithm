namespace Daily_Algorithm._2025_09.day0920;

// [문제 설명] 피자 나눠먹기 3
// https://school.programmers.co.kr/learn/courses/30/lessons/120816

public class No06
{
    public int solution(int slice, int n) {
        // slice * x >= n 인 x의 최소값 

        return (n - 1) / slice + 1;
    }
}