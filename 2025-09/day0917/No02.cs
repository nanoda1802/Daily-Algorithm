namespace Daily_Algorithm._2025_09.day0917;

// [문제 설명] 커피 심부름
// https://school.programmers.co.kr/learn/courses/30/lessons/181837

public class No02
{
    public int Print(string[] order) {
        // 아메 4500, 라떼 5000
        // 무조건 ice
        // anything -> 아메
        // 결제 금액 구하슈
        
        int total = 0;

        string latte = "cafelatte";

        foreach (string o in order)
        {
            if (o.Contains(latte)) total += 5000;
            else total += 4500;
        }
        
        return total;
    }
}