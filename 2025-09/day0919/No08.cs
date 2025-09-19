namespace Daily_Algorithm._2025_09.day0919;

// [문제 설명] 배열 두배 만들기
// https://school.programmers.co.kr/learn/courses/30/lessons/120809

public class No08
{
    public int[] solution(int[] numbers) {
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] *= 2;
        }

        return numbers;
    }
}

// [다른풀이1 - Linq] (select가 map처럼 쓰는 건가봐)
// return numbers.Select(n => n * 2).ToArray();