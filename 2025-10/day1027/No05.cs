namespace Daily_Algorithm._2025_10.day1027;
// 점프와 순간이동
// https://school.programmers.co.kr/learn/courses/30/lessons/12980

// 점프 : K 칸 전진 (사용량=K)  
// 순간이동 : (현재까지 온 거리) x 2 칸으로 이동 (사용량=0)    
// 거리 N이 주어졌을 때, 사용해야 하는 건전지 사용량의 최솟값을 return 
public class No05
{  
    public int solution(int n)  
    {  
        int answer = 0;  
  
        // 처음에 1 점프 후 계속 순간이동 하다가 마지막에만 맞추면 되는 거 아닌감  
        // 아니었따  
  
        while (n>0)  
        {        
            if (n%2!=0)  
            {            
                n -= 1;  
                answer++;        
            }        
            else  
            {  
                n /= 2;  
            }    
        }    
    
        return answer;  
    }  
}

// [다른풀이 - 왜 되는 것...?]  
// n을 2진수로 바꿨을때 1의 갯수가 점프의 횟수  
// n 위치에서 0으로 갈 때 순간이동이 가능하지 못한 순간에 1칸씩만 점프를 뛰면 되는데,  
// 이 과정이 주어진 수를 이진화 했을 때 1의 개수를 구하는 과정과 동일  
  
// [다른풀이 - 상위호환]  
/*
int result = 1;
while(n > 1)
{
    result += n % 2;    
    n /= 2;
}
return result;
*/