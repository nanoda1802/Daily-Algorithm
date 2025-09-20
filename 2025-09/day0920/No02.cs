namespace Daily_Algorithm._2025_09.day0920;

// [문제 설명] 최빈값 구하기
// https://school.programmers.co.kr/learn/courses/30/lessons/120812

public class No02
{
    public int solution(int[] array)
    {
        // array.GroupBy(e => e).Max(g => g.Count()); 여러 개일 때 -1 반환에 걸림 ㅠㅠ

        int answer = -1;
        
        Dictionary<int, int> count = new Dictionary<int, int>();

        for (int i = 0; i < array.Length; i++)
        {
            int currentNum = array[i];
            
            if (count.ContainsKey(currentNum))
            {
                count[currentNum] += 1;
            }
            else
            {
                count.Add(currentNum,1);
            }
        }

        int max = count.Values.Max();
        int checkFlag = 0;
        
        foreach (KeyValuePair<int, int> pair in count)
        {
            if (max == pair.Value)
            {
                answer = pair.Key;
                checkFlag += 1;
            }

            if (checkFlag >= 2) return -1;
        }
        
        return answer;
    }
}