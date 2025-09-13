namespace Daily_Algorithm._2025_09.day0913;

// [문제 설명] ad 제거하기
// https://school.programmers.co.kr/learn/courses/30/lessons/181870

public class No01
{
    public string[] Print(string[] strArr) {
        // 배열 요소 중 ad 포함한 문자열 제거하고
        // 남은 문자열 순서 유지해 새 배열 반환
        List<string> strList = new List<string>(strArr.Length);
        
        for (int i = 0; i < strArr.Length; i++)
        {
            string s = strArr[i];
            if (!s.Contains("ad")) strList.Add(s);
        }

        return strList.ToArray();
    }
}