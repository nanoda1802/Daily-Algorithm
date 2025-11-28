namespace Daily_Algorithm._2025_11.day1128;
// 행렬 테두리 회전하기
// https://school.programmers.co.kr/learn/courses/30/lessons/77485

// 매 회전의 숫자 중 최소값을 순서대로 담은 배열 return
// x1,y1 에서부터 오른쪽으로 x2-x1칸, 아래로 y2-y1칸, 왼쪽으로 x2-x1칸, 위로 y2-y1칸  

// 내 공간지각력에 짜증이 ㄴ ㅏ... 
// 이차원 배열을 좌표평면처럼 쓸 거면 가로가 y고 세로가 x
public class No02
{
    private int[,] table;  
    private int[] dy = { 0, 1, 0, -1 };  
    private int[] dx = { 1, 0, -1, 0 };  
    private int[] moveLimit = new int[4]; 
     
    public int[] solution(int rows, int columns, int[,] queries)  
    {        
        int num = 1;  
        table = new int[rows, columns];  
        for (int i = 0; i < rows; i++)  
        {            
            for (int j = 0; j < columns; j++)  
            {                
                table[i, j] = num++;  
            }        
        }  
        
        int rotateCount = 0;  
        int[] answer = new int[queries.GetLength(0)];  
        for (int i = 0; i < queries.GetLength(0); i++)  
        {            
            moveLimit[0] = moveLimit[2] = queries[i, 3] - queries[i, 1];  
            moveLimit[1] = moveLimit[3] = queries[i, 2] - queries[i, 0];  
            answer[rotateCount++] = RotateAndFindMinValue(queries[i,1]-1,queries[i,0]-1);  
        }  
        
        return answer;  
    }    
    
    private int RotateAndFindMinValue(int x, int y)  
    {        
        int min = int.MaxValue;  
        int prev = table[y,x], cur = 0;  
        int moveCount = 1;  
        
        for (int i = 0; i < 4; i++)  
        {            
            while (moveCount <= moveLimit[i])  
            {                
                x += dx[i]; y += dy[i];  
	            
                cur = table[y,x];  
                table[y,x] = prev;  
                prev = cur;  
                
                moveCount++;                
                if (min > cur) min = cur;  
            }            
            moveCount = 1;   
        } 
        
        return min;  
    }
}

