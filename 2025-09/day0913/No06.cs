namespace Daily_Algorithm._2025_09.day0913;

// [문제 설명] 간단한 식 계산
// https://school.programmers.co.kr/learn/courses/30/lessons/181865

public class No06
{
    public int Print(string binomial) {
        int answer = 0;

        string[] ingredients = binomial.Split(' ');
        int n = int.Parse(ingredients[0]);
        int m = int.Parse(ingredients[2]);
        
        
        switch (ingredients[1])
        {
            case "+" : answer = n + m; break;
            case "-" : answer = n - m; break;
            case "*" : answer = n * m; break;
        }
        
        return answer;
    }
}