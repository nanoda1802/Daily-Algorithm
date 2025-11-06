namespace Daily_Algorithm._2025_11.day1106;
// 프로세스
// https://school.programmers.co.kr/learn/courses/30/lessons/42587

// 프로세스의 중요도가 순서대로 담긴 배열 priorities
// 정수 1~9, 클수록 우선순위 높음  
  
// 몇 번째로 실행되는지 알고싶은 프로세스의 위치를 알려주는 location
// priorities의 인덱스 값  
// 해당 프로세스가 몇 번째로 실행되는지 return  

// 1. 실행 대기 큐(Queue)에서 대기중인 프로세스 하나를 꺼냅니다.  
// 2. 큐에 대기중인 프로세스 중 우선순위가 더 높은 프로세스가 있다면 방금 꺼낸 프로세스를 다시 큐에 넣습니다.  
// 3. 만약 그런 프로세스가 없다면 방금 꺼낸 프로세스를 실행합니다.  
// 3.1 한 번 실행한 프로세스는 다시 큐에 넣지 않고 그대로 종료됩니다.  
public class No01
{
    public int solution(int[] priorities, int location) {  
        int answer = 0;  
        Queue<(int,int)> process = new Queue<(int,int)>();  
        for (int i = 0; i < priorities.Length; i++) process.Enqueue((i,priorities[i]));  
        Array.Sort(priorities,(e1,e2)=>e2-e1);  
        Queue<int> priority = new Queue<int>(priorities);  
          
        while (process.Count > 0)  
        {        
            (int curI, int curP) = process.Dequeue();  
            if (curP == priority.Peek())  
            {            
                answer++;            
                if (curI == location) break;  
                priority.Dequeue();  
            }        
            else  
            {  
                process.Enqueue((curI,curP));  
            }    
        }    
        return answer;  
    }
}

