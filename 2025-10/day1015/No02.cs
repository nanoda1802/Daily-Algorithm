namespace Daily_Algorithm._2025_10.day1015;

// [문제 설명] 2016년
// https://school.programmers.co.kr/learn/courses/30/lessons/12901

public class No02
{
    public string solution(int a, int b)
    {
        // 윤년이래 31 29 31 30 31 30 31 31 30 31 30 31
        string[] answers = { "FRI", "SAT", "SUN", "MON", "TUE", "WED", "THU" };
        int[] dayPerMonth = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
    
        // days의 0~a-2까지의 합이 지난 일수
        // 1월1일 당일 제외해야 하니 -1
        int totalDays = -1; 
        for (int i = 0; i < a-1; i++)
        {
            totalDays += dayPerMonth[i];
        }
    
        // 일수인 b를 더해줌
        totalDays += b;
    
        return answers[totalDays % 7];
    }
}
