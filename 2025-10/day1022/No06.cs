namespace Daily_Algorithm._2025_10.day1022;

// [문제 설명] 바탕화면 정리
// https://school.programmers.co.kr/learn/courses/30/lessons/161990

public class No06
{
    public int[] solution(string[] wallpaper) {
        int[] answer = new int[4];
        // lux luy rdx rdy
        
        // 제일위 lux 제일왼쪽 luy 제일 아래 rdx 제일오른쪽 rdy

        answer[0] = wallpaper.Length;
        answer[1] = wallpaper[0].Length;
        answer[2] = -1;
        answer[3] = -1;

        for (int i = 0; i < wallpaper.Length; i++)
        {
            int first = wallpaper[i].IndexOf('#');
            if (first < 0) continue;
            answer[1] = Math.Min(first, answer[1]);
            
            answer[0] = Math.Min(i, answer[0]);
            answer[2] = Math.Max(i, answer[2]);

            int last = wallpaper[i].LastIndexOf('#');
            answer[3] = Math.Max(last, answer[3]);
        }

        answer[2] += 1;
        answer[3] += 1;
        
        return answer;
    }
}

