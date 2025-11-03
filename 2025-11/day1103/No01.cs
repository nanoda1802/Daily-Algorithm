namespace Daily_Algorithm._2025_11.day1103;
// 타겟 넘버
// https://school.programmers.co.kr/learn/courses/30/lessons/43165

// 사용할 수 있는 숫자가 담긴 배열 numbers, 타겟 넘버 target
// 숫자를 적절히 더하고 빼서 타겟 넘버를 만드는 방법의 수를 return  
// DFS  

// 에라 모르겠다 재귀했는데 풀렸고 이게 DFS래 앙앙...
public class No01
{  
    public int solution(int[] numbers, int target) {  
        int count = 0;  
        Oper(numbers, target, ref count);  
        return count; 
    }  
  
    private void Oper(int[] numbers, int target, ref int count, int sum = 0, int depth = 0)  
    {  
        if (depth == numbers.Length)  
        {        
            if (sum == target) count++;  
            return;  
        }    
        Oper(numbers, target, ref count, sum + numbers[depth], depth + 1);  
        Oper(numbers, target, ref count, sum - numbers[depth], depth + 1);  
    }  
}

// [다른풀이]  
/*
private int Dfs(int[] arr, int target, int idx, int num)
{
    if (idx == arr.Length)    
    {        
        if (target == num) return 1;        
        else return 0;    
    }    
    else        
    {
        return Dfs(arr, target, idx + 1, num + arr[idx]) + Dfs(arr, target, idx + 1, num - arr[idx]);
    }
}

public int solution(int[] numbers, int target) 
{
    int answer = 0;    return Dfs(numbers, target, 0, 0);
}
*/  
  
/*
public int solution(int[] numbers, int target)
{
    return CalcDFS(numbers, target, 0, 0);
}

private int CalcDFS(int[] numbers, int target, int index, int sum)
{
    if (index == numbers.Length)        
        return target == sum ? 1 : 0;    
    else    
    {        
        return CalcDFS(numbers, target, index + 1, sum + numbers[index])               + CalcDFS(numbers, target, index + 1, sum - numbers[index]);    
    }
}
*/