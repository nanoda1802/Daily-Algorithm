namespace Daily_Algorithm._2025_10.day1023;

// [문제설명] 공원 산책  
// https://school.programmers.co.kr/learn/courses/30/lessons/172928  

public class No03
{  
    public int[] solution(string[] park, string[] routes) {  
        // 지나다니는 길을 'O', 장애물을 'X'로 나타낸 직사각형 격자 모양의 공원  
        // S : 시작 지점  
        // ["SOO","OXX","OOO"]  
        // ["방향 거리", "방향 거리" … ] (op n : op쪽 n칸) (1 ≤ n ≤ 9)  
        // ["E 2","S 2","W 1"]    
        // 1. 주어진 방향으로 이동할 때 공원을 벗어나는지 확인합니다.  
        // 2. 주어진 방향으로 이동 중 장애물을 만나는지 확인합니다.  
        // 조건 해당하면 명령을 무시하고 다음 명령을 수행  
        // 좌측 상단의 좌표는 (0, 0), 우측 하단의 좌표는 (H - 1, W - 1)  
        int curX = 0;  
        int curY = 0;  
        int w = park[0].Length;  
        int h = park.Length;  
    
        for (int i = 0; i < h; i++)  
        {        
	        for (int j = 0; j < w; j++)  
            {            
	            if (park[i][j].Equals('S'))  
                {                
	                curY = i;                
	                curX = j;                
	                break;  
                }        
            }    
        }    
        
        foreach (string route in routes)  
        {        
	        int vec;  
            bool isPossible = true;  
            
            switch (route[0])  
            {            
	            case 'N':  
                    vec = curY - (route[2] - '0');  
                    if (vec < 0) continue;  
                    for (int i = curY; i >= vec; i--)  
                    {                    
	                    if (park[i][curX].Equals('X'))  
                        {                        
	                        isPossible = false;  
                            break;  
                        }                
                    }                
                    if (isPossible) curY = vec;  
                    break;  
                case 'W':   
                    vec = curX - (route[2] - '0');  
                    if (vec < 0) continue;  
                    for (int i = curX; i >= vec; i--)  
                    {                    
	                    if (park[curY][i].Equals('X'))   
                        {  
                            isPossible = false;  
                            break;  
                        }                
                    }                
                    if (isPossible) curX = vec;  
                    break;  
                case 'E':   
                    vec = curX + (route[2] - '0');  
                    if (vec > w-1) continue;  
                    for (int i = curX; i <= vec; i++)  
                    {                    
	                    if (park[curY][i].Equals('X'))   
                        {  
                            isPossible = false;  
                            break;  
                        }                
                    }                
                    if (isPossible) curX = vec;  
                    break;  
                case 'S':  
                    vec = curY + (route[2] - '0');  
                    if (vec > h-1) continue;  
                    for (int i = curY; i <= vec; i++)  
                    {                    
	                    if(park[i][curX].Equals('X'))   
                        {  
                            isPossible = false;  
                            break;  
                        }                
                    }                
                    if (isPossible) curY = vec;  
                    break;  
            } 
        }  
        
        return new int[] {curY, curX};
    }
}

