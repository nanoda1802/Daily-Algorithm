namespace Daily_Algorithm._2025_10.day1023;

// [문제 설명] 달리기 경주  
// https://school.programmers.co.kr/learn/courses/30/lessons/178871  
  
public class No02
{  
    public string[] solution(string[] players, string[] callings) {
        // 선수들이 자기 바로 앞의 선수를 추월할 때
        // "추월한 선수의 이름"을 부릅니다.
        
        // 선수들의 이름이 1등부터 현재 등수 순서대로 담긴 문자열 배열 players
        // 해설진이 부른 이름을 담은 문자열 배열 callings
        
        // return 경주가 끝났을 때 선수들의 이름을 1등부터 등수 순서대로 담은 배열
        
        string[] answer = new string[players.Length];
        string first = players[0];
        
        Dictionary<string, (string, string)> row = new Dictionary<string, (string, string)>();
        row.Add(players[0],("head",players[1]));
        row.Add(players[players.Length-1],(players[players.Length-2],"tail"));
        
        for (int i = 1; i < players.Length-1; i++) row.Add(players[i],(players[i-1],players[i+1]));

        foreach (string name in callings)
        {
            string prev = row[name].Item1;
            string prevPrev = row[prev].Item1;
            string next = row[name].Item2;
            
            row[name] = (row[prev].Item1, prev);
            row[prev] = (name, next);
            
            if (!prevPrev.Equals("head")) row[prevPrev] = (row[prevPrev].Item1, name);
            if (!next.Equals("tail")) row[next] = (prev, row[next].Item2);
            if (row[name].Item1.Equals("head")) first = name;
        }

        answer[0] = first;
        for (int i = 1; i < answer.Length; i++)
        {
            answer[i] = row[answer[i-1]].Item2;
        }
        return answer;
    }
}

// [메모] 실패사례
// 배열 순회하며 인덱스 스왑 -> 실패
// 링크드리스트로 노드 옮기기 -> 실패

// [다른풀이] 배열과 딕셔너리를 둘다 쓰면 된다...?
// 이름별 등수를 기록하는 딕셔너리
// 현재 순서를 기록하는 배열
// 딕셔너리에서 등수 갱신해주고 배열에서 swap 해준다
// 배열 덕분에 앞 사람을 찾을 수 있다...!
/*
public string[] solution(string[] players, string[] callings) {
    string[] answer = new string[] {};
    Dictionary<string, int> dict = new Dictionary<string, int>();
    for(int i=0;i<players.Length;i++)
    {
        dict[players[i]] = i;
    }
    foreach(string c in callings)
    {
        int index = dict[c];
        dict[c]--;
        dict[players[index-1]]++;
        string temp = players[index];
        players[index] = players[index-1];
        players[index-1] = temp;
    }
    return players;
}
*/