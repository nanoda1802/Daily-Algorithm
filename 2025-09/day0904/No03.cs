namespace Daily_Algorithm._2025_09.day0904;

// [문제 설명] 카운트 다운
// 정수 start_num와 end_num가 주어질 때, start_num에서 end_num까지 1씩 감소하는 수들을 차례로 담은 리스트를 return하도록 solution 함수를 완성해주세요.
// https://school.programmers.co.kr/learn/courses/30/lessons/181899

public class No03
{
    public int[] solution(int start_num, int end_num) {
        int[] answer = new Int32[start_num-end_num+1];

        for (int i = 0; i <= start_num-end_num; i++)
        {
            answer[i] = start_num - i;
        }
        
        return answer;
    }
}

// [다른 풀이] Linq 사용 Enumerable.Range()