namespace Daily_Algorithm._2025_09.day0910;

// [문제 설명] n보다 커질 때까지 더하기
// https://school.programmers.co.kr/learn/courses/30/lessons/181884

public class No08
{
    public int Print(int[] numbers, int n) {
        int answer = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            answer += numbers[i];
            if (answer > n) break;
        }

        return answer;
    }
}