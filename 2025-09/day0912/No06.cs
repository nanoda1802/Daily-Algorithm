namespace Daily_Algorithm._2025_09.day0912;

// [문제 설명] 특정 문자열로 끝나는 가장 긴 부분 문자열 찾기
// https://school.programmers.co.kr/learn/courses/30/lessons/181872

public class No06
{
    public string Print(string myString, string pat) {
        // LastIndexOf? FindLastIndex? 아무튼 뒤에서 pat 찾고
        // myString의 0번 부터 pat까지 반환
        
        int idx = myString.LastIndexOf(pat);
        return myString.Substring(0, idx+pat.Length);
    }
}

// [다른풀이1 - 단축 버전]
// return myString.Substring(0, myString.LastIndexOf(pat) + pat.Length);

// [다른풀이2 - Substring 편하게 하고 pat 붙이기]
// return answer = myString.Substring(0,idx) + pat;
