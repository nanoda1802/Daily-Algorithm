namespace Daily_Algorithm._2025_09.day0911;

// [문제 설명] 원하는 문자열 찾기
// https://school.programmers.co.kr/learn/courses/30/lessons/181878

public class No05
{
    public int Print(string myString, string pat) {
        return myString.ToUpper().Contains(pat.ToUpper()) ? 1 : 0;
    }
}

// [메모] 저번부터 IndexOf로 포함 여부를 구분하는데 이유가 뭘까...
// 성능도 가독성도 Contains 쪽이 낫다고 알고 있는디...