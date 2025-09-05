namespace Daily_Algorithm._2025_09.day0905;

// [문제 설명] flag에 따라 다른 값 반환
// https://school.programmers.co.kr/learn/courses/30/lessons/181933

public class No09
{
    public int Print(int a, int b, bool flag) {
        return flag ? a + b : a - b;
    }
}
