namespace Daily_Algorithm._2025_09.day0906;

// [문제 설명] 접두사인지 확인
// https://school.programmers.co.kr/learn/courses/30/lessons/181906

public class No11
{
    public int Print(string my_string, string is_prefix)
    {
        return my_string.StartsWith(is_prefix) ? 1 : 0;
    }
}

// [메모]
// 이렇게 있는 메서드로 풀 거면 뭐하러 공부를 하나요