namespace Daily_Algorithm._2025_11.day1112;
// 스킬트리
// https://school.programmers.co.kr/learn/courses/30/lessons/49993

// 선행 스킬 순서 skill ("CBD")
// 유저들이 만든 스킬트리를 담은 배열 skill_trees (["BACDE", "CBADF", "AECB", "BDA"])
// skill_trees 중에 가능한 스킬트리 개수를 return  
public class No01
{
    public int solution(string skill, string[] skill_trees) {  
        int answer = 0;  
        Dictionary<char,int> skillId =  new Dictionary<char,int>();  
        for (int i = 0; i < skill.Length; i++) skillId[skill[i]] = i;  
  
        foreach (string tree in skill_trees)  
        {        
            bool[] learned = new bool[skill.Length];  
            bool flag = true;  
            foreach (char c in tree)  
            {            
                if (skillId.TryGetValue(c, out int idx))  
                {                
                    if (idx>0 && !learned[idx-1])  
                    {                    
                        flag =  false;  
                        break;  
                    }                
                    learned[idx] = true;  
                }        
            }        
            if (flag) answer++;  
        }    
    
        return answer;  
    }
}

