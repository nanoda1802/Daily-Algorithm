namespace Daily_Algorithm._2025_10.day1005;

// [문제 설명] 두 정수 사이의 합
// https://school.programmers.co.kr/learn/courses/30/lessons/12912

public class No10
{
    public long solution(int a, int b) {
        // (첫항 + 끝항) * 항개수 / 2

        long big = a > b ? a : b;
        long small = big == a ? b : a;
        
        return (a + b) * (big-small+1) / 2;
    }
}

// [메모] 찾았다 Tuple로 둘 중 큰 넘 작은 넘 구분하기
// (var minValue, var maxValue) = a > b ? (b, a) : (a, b);