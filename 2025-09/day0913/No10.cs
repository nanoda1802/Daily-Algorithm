namespace Daily_Algorithm._2025_09.day0913;

// [문제 설명] 빈 배열에 추가, 삭제하기
// https://school.programmers.co.kr/learn/courses/30/lessons/181860

public class No10
{
    public int[] Print(int[] arr, bool[] flag) {
        // 빈 배열 X
        // flag[i]가 true : X 맨 뒤에 arr[i]를 arr[i]*2 번 추가
        // flag[i]가 false : X 마지막에서 arr[i]개 원소 제거
        
        int[] answer = new int[] {};
        int prevLen = 0;
        
        // flag를 순회혀
        // true) arr[i] * 2 만큼 answer의 길이 늘리고, arr[i] 그만큼 넣어 
        // false) 뒤에서부터 arr[i] 만큼 요소 제거하고, arr[i] 만큼 길이 줄여

        for (int i = 0; i < flag.Length; i++)
        {
            prevLen = answer.Length;
            
            if (flag[i])
            {
                Array.Resize(ref answer,prevLen + arr[i]*2);

                for (int j = prevLen; j < answer.Length; j++)
                {
                    answer[j] = arr[i];
                }
            }
            else
            {
                Array.Resize(ref answer, prevLen - arr[i]);
            }
        }
        
        return answer;
    }
}

// [다른 풀이1 - Stack] 뒤에서 넣고 뒤에서 빼니까!
// 어차피 Collections을 쓸 거라면 무지성 List 말고 특화된 애를 고민해보기