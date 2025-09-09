namespace Daily_Algorithm._2025_09.day0909;

// [문제 설명] 정수 찾기
// https://school.programmers.co.kr/learn/courses/30/lessons/181840

public class No10
{
    public int Print(int[] num_list, int n)
    {
        int result = Array.Find(num_list, el => el == n);
        return result == n ? 1 : 0;
    }
}