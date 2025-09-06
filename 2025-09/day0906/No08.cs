namespace Daily_Algorithm._2025_09.day0906;

// [문제 설명] 수 조작하기 2
// https://school.programmers.co.kr/learn/courses/30/lessons/181925

public class No08
{
    public string Print(int[] numLog) {
        
        string answer = "";
        
        for (int i = 1; i < numLog.Length; i++)
        {
            int operNum = numLog[i] - numLog[i - 1];

            switch (operNum)
            {
                case 1: answer += "w"; break;
                case -1: answer += "s"; break;
                case 10: answer += "d"; break;
                case -10: answer += "a"; break;
            }
        }
        
        return answer;
    }
}