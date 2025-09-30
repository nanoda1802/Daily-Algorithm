namespace Daily_Algorithm._2025_09.day0929;

// [문제 설명] 다항식 더하기
// https://school.programmers.co.kr/learn/courses/30/lessons/120863

public class No05
{
    public string solution(string polynomial)
    {
        string answer = String.Empty;
        
        int xNum = 0;
        int constNum = 0;

        string[] ings = polynomial.Split(' ');

        for (int i = 0; i < ings.Length; i+=2)
        {
            if (ings[i].Contains('x'))
            {
                xNum += ings[i].Length == 1 ? 1 : int.Parse(ings[i].Remove(ings[i].Length - 1));
            }
            else
            {
                constNum += int.Parse(ings[i]);
            }
        }

        if (xNum == 0 && constNum == 0)
        {
            answer = "";
        } 
        else if (xNum == 0)
        {
            answer = "" + constNum;
        }
        else if (constNum == 0)
        {
            answer = xNum == 1 ? "x" : xNum + "x";
        }
        else
        {
            answer = xNum == 1 ? "x + " + constNum : xNum + "x + " + constNum;
        }

        return answer;
    }
}