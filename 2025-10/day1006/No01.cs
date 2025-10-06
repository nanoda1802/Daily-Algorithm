namespace Daily_Algorithm._2025_10.day1006;

// [문제 설명] 나누어 떨어지는 숫자 배열
// https://school.programmers.co.kr/learn/courses/30/lessons/12910

public class No01
{
    public int[] solution(int[] arr, int divisor) {
        int[] answer = arr.Where(e => e % divisor == 0).OrderBy(e => e).ToArray();
        return answer.Length != 0 ? answer : [-1]; 
    }
}

// [메모] " new int[] {-1} == [-1] "