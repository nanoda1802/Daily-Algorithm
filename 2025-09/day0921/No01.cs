namespace Daily_Algorithm._2025_09.day0921;

// [문제 설명] 옷가게 할인받기
// https://school.programmers.co.kr/learn/courses/30/lessons/120818

public class No01
{
    public int solution(int price)
    {
        if (price >= 500000) return (int)(price * 0.8f);
        if (price >= 300000) return (int)(price * 0.9f);
        if (price >= 100000) return (int)(price * 0.95f);

        return price;
    }
}