namespace Daily_Algorithm._2025_10.day1001;

// [문제 설명] 평행
// https://school.programmers.co.kr/learn/courses/30/lessons/120875

public class No01
{
    public int solution(int[,] dots) {
        // 두 점 기울기...
        // 1-2 / 3-4
        // 1-3 / 2-4
        // 1-4 / 2-3
        // 세 기울기 절대값 중 같은 게 있으면 1

        int y1 = (dots[0, 1] - dots[1, 1]);
        int x1 = (dots[0, 0] - dots[1, 0]);
        int y2 = (dots[2, 1] - dots[3, 1]);
        int x2 = (dots[2, 0] - dots[3, 0]);

        if (y1 * x2 == y2 * x1) return 1;
        
        int y3 = (dots[0, 1] - dots[2, 1]);
        int x3 = (dots[0, 0] - dots[2, 0]);
        int y4 = (dots[1, 1] - dots[3, 1]);
        int x4 = (dots[1, 0] - dots[3, 0]);
        
        if (y3 * x4 == y4 * x3) return 1;
        
        int y5 = (dots[0, 1] - dots[3, 1]);
        int x5 = (dots[0, 0] - dots[3, 0]);
        int y6 = (dots[1, 1] - dots[2, 1]);
        int x6 = (dots[1, 0] - dots[2, 0]);
        
        if (y5 * x6 == y6 * x5) return 1;
        
        return 0;
    }
}

// [메모] float 일치비교는 오류 가능성이 있음 -> 나누기 결과 비교 대신 비례식으로 해결
// 기울기 공식 : (y2-y1) / (x2-x1)