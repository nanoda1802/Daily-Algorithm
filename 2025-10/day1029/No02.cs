namespace Daily_Algorithm._2025_10.day1029;
// n^2 배열 자르기
// https://school.programmers.co.kr/learn/courses/30/lessons/87390

//    [1][2][3][4][5]
// [1] 1  2  3  4  5 
// [2] 2  2  3  4  5 
// [3] 3  3  3  4  5 
// [4] 4  4  4  4  5 
// [5] 5  5  5  5  5   

// 0 1 2 3 4  5 6 7 8 9  10 11 12 13 14  15 16 17 18 19  20 21 22 23 24  
// 1 2 3 4 5  2 2 3 4 5  3  3  3  4  5   4  4  4  4  5   5  5  5  5  5   
// 행 : (i / n) + 1
// 열 : (i % n) + 1  

// x행은 x가 x개만큼 있고, 나머지가 (x+1, x+2, ... , n) 으로 채워짐  
// y열이 x보다 작거나 같으면 해당 칸의 값은 (x)
// y열이 x보다 크면 해당 칸의 값은 (x+차이 => y)
public class No02
{  
    public int[] solution(int n, long left, long right) {  
        int[] answer = new int[right-left+1];  
    
        for (long i = left; i <= right; i++)  
        {        
            int row = (int) (i / n) + 1;  
            int column = (int) (i % n) + 1;  
            answer[i - left] = row <= column ? column : row;  
        }    
    
        return answer;  
    }
}