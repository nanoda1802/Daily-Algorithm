namespace Daily_Algorithm._2025_09.day0907;

// [문제 설명] 카운트 업
// https://school.programmers.co.kr/learn/courses/30/lessons/181920

public class No03
{
    public int[] Print(int start_num, int end_num) {
        int[] answer = new int[end_num - start_num + 1];

        for (int i = 0; i <= end_num - start_num; i++) answer[i] = start_num+i;
        
        return answer;
    }
}

// [다른풀이1 - Linq]
// return Enumerable.Range(start, end - start + 1).ToArray();

// [다른풀이2 - List]
/*
    List<int> answer = new List<int>();
    for (int i = start_num; i <= end_num; i++) answer.Add(i);
    return answer.ToArray();
*/