namespace Daily_Algorithm._2025_10.day1007;

// [문제 설명] 부족한 금액 계산하기
// https://school.programmers.co.kr/learn/courses/30/lessons/82612

public class No04
{
    public long solution(int price, int money, int count)
    {
        long answer = (long) price * ((1+count) * count/2) - money;
        
        return answer <= 0 ? 0 : answer;
    }
}