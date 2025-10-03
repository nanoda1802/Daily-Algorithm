namespace Daily_Algorithm._2025_10.day1003;

// [문제 설명] 종이 자르기
// https://school.programmers.co.kr/learn/courses/30/lessons/120922

public class No02
{
    public int solution(int M, int N) {
        // 세로 가위질 -> M-1 번 (현재 M 조각)
        // 가로 가위질 -> (N-1) * M 번

        return (M - 1) + (N - 1) * M;
    }
}

// [다른풀이1 - 풀어쓰기] -> 내 답을 풀어 쓰면 이거임...
// return M * N - 1; 