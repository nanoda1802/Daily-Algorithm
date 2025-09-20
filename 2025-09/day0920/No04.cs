namespace Daily_Algorithm._2025_09.day0920;

// [문제 설명] 피자 나눠먹기 1
// https://school.programmers.co.kr/learn/courses/30/lessons/120814

public class No04
{
    public int solution(int n) {
        // 7x >= n 인 x의 최소값
        return n % 7 == 0 ? n / 7 : n / 7 + 1;
    }
}

// [다른풀이1 - 무슨 공식인 겨]
// return (n-1)/7+1;

// 올림함수 공식
// 나머지(소수부분)이 발생하면 무조건 올려야하기 때문에
// 기존 숫자에서 1을 뺀 후 연산하면 해답이 나옴
// 그냥 n/7이면 안되는 이유는, n이 7의 배수인 경우 해답보다 1 큰 숫자가 나오기 때문 