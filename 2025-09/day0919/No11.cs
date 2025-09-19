namespace Daily_Algorithm._2025_09.day0919;

// [문제 설명] 각도기
// https://school.programmers.co.kr/learn/courses/30/lessons/120829

public class No11
{
    public int solution(int angle) {
        if (angle > 0 && angle < 90) return 1;
        if (angle is > 90 and < 180) return 3;
        if (angle == 90) return 2;
        if (angle == 180) return 4;
        
        return 0;
    }
}

// [메모] 패턴으로 조건식 병합
// (변수) is (범위1) (and/or) (범위2)
