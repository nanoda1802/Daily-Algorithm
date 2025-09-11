namespace Daily_Algorithm._2025_09.day0911;

// [문제 설명] 길이에 따른 연산
// https://school.programmers.co.kr/learn/courses/30/lessons/181879

public class No04
{
    public int Print(int[] num_list) {
        // 길이 11 이상이면 원소 합
        // 길이 10 이하면 원소 곱
        return num_list.Length >= 11 ? num_list.Sum() : num_list.Aggregate((acc,cur)=>acc*cur);
    }
}