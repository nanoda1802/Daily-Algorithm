namespace Daily_Algorithm._2025_10.day1015;

// [문제 설명] 모의고사
// https://school.programmers.co.kr/learn/courses/30/lessons/42840

public class No03
{
    public int[] solution(int[] answers) {
        // 1 2 3 4 5
        // 2 1 2 3 2 4 2 5
        // 3 3 1 1 2 2 4 4 5 5
    
        int[] corrects = new int[3];

        int[] answer1 = { 1, 2, 3, 4, 5 };
        int[] answer2 = { 5, 1, 3, 4 };
        int[] answer3 = { 3, 1, 2, 4, 5 };

        for (int i = 0; i < answers.Length; i++)
        {
            if (answer1[i%5] == answers[i]) corrects[0]++;
            if ((i % 2 == 0) ? (2 == answers[i]) : (answer2[(i+1)/2 % 4] == answers[i])) corrects[1]++;
            if (answer3[i/2 % 5] == answers[i]) corrects[2]++;
        }

        int max = corrects.Prepend(0).Max(); // [메모] Prepend는 시퀀스의 첫 위치에 특정값을 삽입해두는 메서드 (Max 호출 전에 빈 배열로 인한 오류 예방 때문인 듯?)

        List<int> answer = new List<int>(3);
    
        for (int i = 0; i < corrects.Length; i++)
        {
            if (max == corrects[i]) answer.Add(i+1);
        }
    
        return answer.ToArray();
    }
}
