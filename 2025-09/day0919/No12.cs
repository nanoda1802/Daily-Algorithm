namespace Daily_Algorithm._2025_09.day0919;

// [문제 설명] 양꼬치
// https://school.programmers.co.kr/learn/courses/30/lessons/120830

public class No12
{
    public int solution(int n, int k) {
        //  10인분 당 음료 서비스
        
        int ten = n / 10;
        
        if (ten > 0 && k > 0)
        {
            return 12000 * n + 2000 * (Math.Clamp(k - ten,0,k));
        }

        return 12000 * n + 2000 * k;
    }
}