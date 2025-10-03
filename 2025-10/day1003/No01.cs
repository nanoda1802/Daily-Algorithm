namespace Daily_Algorithm._2025_10.day1003;

// [문제 설명] 문자열 밀기
// https://school.programmers.co.kr/learn/courses/30/lessons/120921

public class No01
{
    public int solution(string A, string B) {
        int len = A.Length;
        bool isEqual = true;

        if (A.Equals(B)) return 0;
        
        for (int i = 1; i <= len; i++)
        {
            isEqual = true;
            
            for (int j = 0; j < len; j++)
            {
                if (!A[j].Equals(B[(j + i) % len]))
                {
                    isEqual = false;
                    break;
                }
            }

            if (isEqual) return i;
        }
        
        return -1;
    }
}

// [다른풀이1 - 천재] B를 이어 붙이고 A의 위치를 찾아보면 끗...
// return (B+B).IndexOf(A); 