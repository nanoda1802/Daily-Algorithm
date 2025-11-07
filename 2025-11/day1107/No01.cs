namespace Daily_Algorithm._2025_11.day1107;
// 방문 길이
// https://school.programmers.co.kr/learn/courses/30/lessons/49994
 
public class No01
{
    public int solution(string dirs) {
        int answer = 0;

        bool[,,,] visited = new bool[11,11,11,11];
        int curX = 5;
        int curY = 5;
        int nextX = curX;
        int nextY = curY;
        
        foreach (char dir in dirs)
        {
            switch (dir)
            {
                case 'U' : 
                    if (nextY+1 > 10) continue;
                    nextY += 1; break;
                case 'D' : 
                    if (nextY-1 < 0) continue;
                    nextY -= 1; break;
                case 'R' : 
                    if (nextX+1 > 10) continue;
                    nextX += 1; break;
                case 'L' : 
                    if (nextX-1 < 0) continue;
                    nextX -= 1; break;
            }

            if (!visited[curX,curY,nextX,nextY] 
                && !visited[nextX,nextY,curX,curY]) answer++;

            visited[curX, curY, nextX, nextY] = visited[nextX, nextY, curX, curY] = true;
            
            curX = nextX;
            curY = nextY;
        }
        
        return answer;
    }
}

