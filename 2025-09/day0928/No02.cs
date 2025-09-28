namespace Daily_Algorithm._2025_09.day0928;

// [문제 설명] 숫자 찾기
// https://school.programmers.co.kr/learn/courses/30/lessons/120904

public class No02
{
    public int solution(int num, int k) {
        int answer = 0;
        string n = num + "";
        
        int idx = n.IndexOf(k + "");

        return idx != -1 ? idx + 1 : idx;
    }
}
