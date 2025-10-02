namespace Daily_Algorithm._2025_10.day1002;

// [문제 설명] 치킨 쿠폰
// https://school.programmers.co.kr/learn/courses/30/lessons/120884

public class No05
{
    public int solution(int chicken) {
        // 치킨 하나 = 쿠폰 하나
        // 치킨 열 -> 서비스 치킨 하나

        // a = n / 10
        // service += a
        // b = a / 10
        // service += b
        // 몫이 0일때 까지
        
        int service = 0;

        int currentChicken = chicken;
        int serviceCount = chicken / 10;
        int leftChicken = chicken % 10;
        
        while (currentChicken >= 10)
        {
            service += serviceCount;

            currentChicken = serviceCount + leftChicken;
            serviceCount = currentChicken / 10;
            leftChicken = currentChicken % 10;
        }
        
        return service;
    }
}