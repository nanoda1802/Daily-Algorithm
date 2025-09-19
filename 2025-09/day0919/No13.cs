namespace Daily_Algorithm._2025_09.day0919;

// [문제 설명] 배열의 평균값
// https://school.programmers.co.kr/learn/courses/30/lessons/120817

public class No13
{
    public double solution(int[] numbers) {
        return numbers.Sum() / (double) numbers.Length;
    }
}

// [다른풀이1 - Linq] -> Average가 있네 ㅎㅎ;;
// return numbers.Average();

