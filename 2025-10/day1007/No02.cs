namespace Daily_Algorithm._2025_10.day1007;

// [문제 설명] 약수의 개수와 덧셈
// https://school.programmers.co.kr/learn/courses/30/lessons/77884

public class No02
{
    public int solution(int left, int right)
    {
        int answer = (left + right) * (right - left + 1) / 2;

        for (int i = left; i <= right; i++)
        {
            for (int j = 0; j*j <= i; j++)
            {
                if (j*j == i) answer -= i * 2;
            }
        }   
        
        return answer;
    }
}

// [메모] 약수의 개수가 홀수 => 제곱수!
// 총합 구한 뒤 범위 내 제곱수인 애들을 두 번 빼주면 해결!