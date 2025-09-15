namespace Daily_Algorithm._2025_09.day0915;

// [문제 설명] 문자열 묶기
// https://school.programmers.co.kr/learn/courses/30/lessons/181855

public class No02
{
    public int Print(string[] strArr) {
        // 길이 카운팅
        // 제일 많은 길이 return
        
        // 딕셔너리?

        Dictionary<int, int> lenDic = new Dictionary<int, int>();

        foreach (string s in strArr)
        {
            if(!lenDic.TryAdd(s.Length, 1)) lenDic[s.Length] += 1;
        }

        int answer = 0;

        foreach (int i in lenDic.Values)
        {
            if (answer < i) answer = i;
        }

        return answer;
    }
}

// [다른풀이1 - Linq]
// return strArr.GroupBy(x => x.Length).Max(y => y.Count());
// 길이별로 그루핑 후 count 최대인 녀석 찾기