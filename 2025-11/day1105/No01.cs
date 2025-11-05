namespace Daily_Algorithm._2025_11.day1105;
// 소수 찾기
// https://school.programmers.co.kr/learn/courses/30/lessons/42839

// 각 종이 조각에 적힌 숫자가 적힌 문자열 numbers
// 종이 조각을 붙여 만들 수 있는 소수가 몇 개인지 return
// 모두 써야할 필요는 없음 3장 중 1~2개만 써도 가능  
// 11과 011은 같은 숫자로 취급  
  
// 숫자 조합 후 소수 판정?  
// 소수 체 만들고 숫자 조합?  
  
// 조합 만들고 소수 판정  
// 만들어진 조합은 방문기록해두기  
  
// 숫자 자리수가 numbers 개수가 될 때까지  
// 이미 쓴 숫자면 X
// 이미 만들어진 조합이면 X

public class No01
{  
    public int solution(string numbers) {  
        int answer = 0;  
        DFS(numbers, new bool[numbers.Length],new HashSet<int>(),"",ref answer);  
        return answer;  
    }  
  
    private void DFS(string paper, bool[] isUsed, HashSet<int> combi, string num, ref int count) {  
        if (num.Length > paper.Length) return;  
        for (int i = 0; i < paper.Length; i++)  
        {        
            if (!isUsed[i])  
            {            
                isUsed[i] = true;  
                string curNum = num + paper[i];  
                if (IsPrime(curNum, combi)) count++;  
                DFS(paper, isUsed, combi, curNum, ref count);  
                isUsed[i] = false;  
            }    
        }
    }  
  
    private bool IsPrime(string num, HashSet<int> combi)  
    {  
        if (!int.TryParse(num, out int n)) return false;  
        if (n <= 1 || ((n != 2) && (n % 2 == 0)) ) return false;  
        if (!combi.Add(n)) return false;  
  
        for (int i = 3; i*i <= n; i += 2)  
        {        
            if (n % i == 0) return false;  
        }        
    
        return true;  
    }
}

// [메모] 다음순열? Next Permutation