namespace Daily_Algorithm._2025_10.day1020;

// [문제 설명] 대충 만든 자판
// https://school.programmers.co.kr/learn/courses/30/lessons/160586

public class No02
{
    public int[] solution(string[] keymap, string[] targets) {
        int[] answer = new int[targets.Length];
        Dictionary<char, int> press = new Dictionary<char, int>();

        foreach (string s in keymap)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (!press.TryAdd(s[i], i+1) && press[s[i]] > i+1)
                {
                    press[s[i]] = i+1;
                }
            }
        }

        for (int i = 0; i < targets.Length; i++)
        {
            int pressCount = 0;

            foreach (char c in targets[i])
            {
                if (press.TryGetValue(c, out int cnt))
                {
                    pressCount += cnt;
                }
                else
                {
                    pressCount = -1;
                    break;
                }
            }
            
            answer[i] = pressCount;
        }
        
        return answer;
    }
}

