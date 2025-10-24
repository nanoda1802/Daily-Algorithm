namespace Daily_Algorithm._2025_10.day1024;

// [문제설명] 신고 결과 받기  
// https://school.programmers.co.kr/learn/courses/30/lessons/92334 

// 이용자의 ID가 담긴 문자열 배열 id_list    
// 각 이용자가 신고한 이용자의 ID 정보가 담긴 문자열 배열 report ("이용자id 신고한id")  
// 정지 기준이 되는 신고 횟수 k    
// 각 유저별로 처리 결과 메일을 받은 횟수를 배열에 담아 return    
// return 하는 배열은 id_list에 담긴 id 순서대로 각 유저가 받은 결과 메일 수  
// 신고 횟수에 제한은 없습니다. 서로 다른 유저를 계속해서 신고할 수 있습니다.  
// 한 유저를 여러 번 신고할 수도 있지만, 동일한 유저에 대한 신고 횟수는 1회로 처리됩니다.  
// k번 이상 신고된 유저는 게시판 이용이 정지되며, 해당 유저를 신고한 모든 유저에게 정지 사실을 메일로 발송  

public class No01 
{  
    public int[] solution(string[] id_list, string[] report, int k) {  
        int[] answer = new int[id_list.Length];  
        Dictionary<string, HashSet<string>> reports = new Dictionary<string, HashSet<string>>(); // 유저별 신고받은사람  
        Dictionary<string, int> ids = new Dictionary<string, int>(); // 유저별 인덱스
        
        for (int i = 0; i < id_list.Length; i++)  
        {        
            ids.Add(id_list[i], i);  
            reports.Add(id_list[i],new HashSet<string>());  
        }    
        foreach (string r in report)  
        {        
            string[] users = r.Split(' ');  
            reports[users[1]].Add(users[0]);  
        }  
        foreach (KeyValuePair<string, HashSet<string>> pair in reports)  
        {        
            if (pair.Value.Count >= k)  
            {            
                foreach (string name in pair.Value) answer[ids[name]]++;  
            }    
        }    
        return answer;  
    }
}