namespace Daily_Algorithm._2025_09.day0907;

// [문제 설명] 간단한 논리 연산
// https://school.programmers.co.kr/learn/courses/30/lessons/181917

public class No06
{
    public bool Print(bool x1, bool x2, bool x3, bool x4) {
        return (x1 || x2) && (x3 || x4);
    }
}

// [다른풀이1 - 비트연산]
// (x1 | x2) & (x3 | x4) <- 되나 본데...?