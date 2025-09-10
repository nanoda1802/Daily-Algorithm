namespace Daily_Algorithm._2025_09.day0910;

// [문제 설명] 할 일 목록
// https://school.programmers.co.kr/learn/courses/30/lessons/181885

using System.Collections.Generic;

public class No07
{
    public string[] Print(string[] todo_list, bool[] finished) {
        List<string> answer = new List<string>();
        
        for (int i = 0; i < todo_list.Length; i++) {
            if (!finished[i])
            {
                answer.Add(todo_list[i]);
            }
        }
        
        return answer.ToArray();
    }
}

// [다른풀이1 - Linq] <- Where에서 현재 요소의 index에 접근할 수 있다
// return todo_list.Where((w, index) => !finished[index]).ToArray();
