using System.Diagnostics;

namespace Daily_Algorithm._2025_09.day0928;

// [문제 설명] OX 퀴즈
// https://school.programmers.co.kr/learn/courses/30/lessons/120907

public class No03
{
    public string[] solution(string[] quiz) {
        string[] answer = new string[quiz.Length];
        int idx = 0;
        
        foreach (string oper in quiz)
        {
            string[] ing = oper.Split(" ");
            int[] nums = new int[3];

            for (int i = 0; i < ing.Length; i+=2)
            {
                nums[i/2] = ing[i].StartsWith("-") ? -int.Parse(ing[i].Remove(0,1)) : int.Parse(ing[i]); 
            }

            if (ing[1].Equals("+"))
            {
                answer[idx++] = nums[2] == nums[0] + nums[1] ? "O" : "X";
            }
            else if (ing[1].Equals("-"))
            {
                answer[idx++] = nums[2] == nums[0] - nums[1] ? "O" : "X";
            }
        }
        
        return answer;
    }
}

// [메모] 그냥 Parse에 넣으면 알아서 - 인식해서 음수로 바꾸나 보다...