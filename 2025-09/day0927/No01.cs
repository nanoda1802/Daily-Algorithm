namespace Daily_Algorithm._2025_09.day0927;

// [문제 설명] 369게임
// https://school.programmers.co.kr/learn/courses/30/lessons/120891

public class No01
{
    public int solution(int order) {
        int answer = 0;
        string num = order + "";

        foreach (char c in num)
        {
            if (c == '3' || c == '6' || c == '9') answer += 1;
        }
        
        return answer;
    }
}

// [다른풀이1 - 각 자리 확인하기]
/*
    int answer = 0;
    while(order>1)
    {
        if(order%10 % 3 == 0 && order%10 != 0)
            answer++;
        order/=10;
    }
    return answer;
*/