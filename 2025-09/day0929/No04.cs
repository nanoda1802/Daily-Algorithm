namespace Daily_Algorithm._2025_09.day0929;

// [문제 설명] 캐릭터의 좌표
// https://school.programmers.co.kr/learn/courses/30/lessons/120861

public class No04
{
    public int[] solution(string[] keyinput, int[] board) {
        int[] answer = new int[2];
        int curX = 0;
        int curY = 0;
        
        for (int i = 0; i < keyinput.Length; i++)
        {
            curX = answer[0];
            curY = answer[1];
            
            switch (keyinput[i])
            {
                case "up" : answer[1] = Math.Clamp(curY + 1, curY, (board[1]-1)/2); break;
                case "down" : answer[1] = Math.Clamp(curY - 1, -(board[1]-1)/2, curY); break;
                case "left" : answer[0] = Math.Clamp(curX - 1, -(board[0]-1) / 2, curX); break;
                case "right" : answer[0] = Math.Clamp(curX + 1, curX, (board[0]-1)/2); break;
            }
        }
        
        return answer;
    }
}