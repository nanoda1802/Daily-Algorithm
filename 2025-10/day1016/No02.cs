namespace Daily_Algorithm._2025_10.day1016;

// [문제 설명] 과일장수
// https://school.programmers.co.kr/learn/courses/30/lessons/125808

public class No02
{
    public int solution(int k, int m, int[] score) {
        // 한 박스 가격 = 최저가 * 사과 개수
        // 가지고 있는 사과로 얻을 수 있는 최대 이익 구하기
        
        int answer = 0;
        
        Array.Sort(score);

        for (int i = score.Length - m; i >= 0; i -= m)
        {
            answer += score[i] * m;
        }
        
        return answer;
    }
}
