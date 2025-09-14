namespace Daily_Algorithm._2025_09.day0914;

// [문제 설명] 배열 만들기 6
// https://school.programmers.co.kr/learn/courses/30/lessons/181859

public class No03
{
    public int[] Print(int[] arr) {
        // arr는 0과 1만 요소로 가짐
        // i 초기값 = 0
        // i < arr.Length 면 아래 반복
        
        // stk가 빈 배열이면 arr[i] 추가하고 i += 1
        // stk의 마지막 요소가 arr[i]랑 같으면 그 요소 제거하고 i += 1
        // 다르면 arr[i] 추가하고 i += 1
        
        // 만약 stk 빈 배열 되면 { -1 } 반환
        
        Stack<int> stk = new Stack<int>();
        
        for (int i = 0; i < arr.Length; i++)
        {
            if (stk.Count == 0 || stk.Peek() != arr[i]) stk.Push(arr[i]);
            else stk.Pop();
        }

        return stk.Count == 0 ? new int[] { -1 } : stk.Reverse().ToArray();
    }
}

// [메모] Stack을 ToArray하려면 꼭꼭 뒤집어줘야함.........