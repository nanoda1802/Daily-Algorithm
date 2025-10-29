namespace Daily_Algorithm._2025_10.day1029;
// 괄호 회전하기
// https://school.programmers.co.kr/learn/courses/30/lessons/76502
public class No01
{  
    public int solution(string s) {  
        int answer = 0;  
        Stack<char> charStack = new Stack<char>();  
        for (int i = 0; i < s.Length; i++)  
        {        
            charStack.Clear();  
            bool check = true;  
            for (int j = 0; j < s.Length; j++)  
            {            
                char cur = s[(i+j) % s.Length];  
                switch (cur)  
                {                
                    case ')':  
                        if (!charStack.TryPop(out var c0) || !c0.Equals('(')) check = false;  
                        break;  
                    case '}':   
                        if (!charStack.TryPop(out var c1) || !c1.Equals('{')) check = false;  
                        break;  
                    case ']':   
                        if (!charStack.TryPop(out var c2) || !c2.Equals('[')) check = false;  
                        break;  
                    default:   
                        charStack.Push(cur);  
                        break;  
                }        
            }        
            if (check && charStack.Count == 0) answer++;  
        }    
        return answer;  
    }
}

// [메모] 콜스택에 비유해주셔서 이해가 됐음  
// 메서드가 쌓이다가 블록 마지막에 빼는 것 처럼  
// 스택에 넣어주다가 닫힌 괄호가 나오면?  
// pop -> 짝이 맞으면 계속 / 짝이 안 맞으면 break