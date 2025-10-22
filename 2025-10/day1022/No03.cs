namespace Daily_Algorithm._2025_10.day1022;

// [문제 설명] 햄버거 만들기
// https://school.programmers.co.kr/learn/courses/30/lessons/133502

public class No03
{
    public int solution(int[] ingredient) {
        // 1빵 2야채 3고기
        int answer = 0;
        List<int> ings = new List<int>();

        foreach (int i in ingredient)
        {
           ings.Add(i);
           int len = ings.Count;
           if (len >= 4 && (ings[len-4]==1 && ings[len-3]==2 && ings[len-2]==3 && ings[len-1]==1))
           {
               ings.RemoveRange(len - 4, 4);
               answer += 1;
           }
        }
        
        return answer;
    }
}

