namespace Daily_Algorithm._2025_10.day1017;

// [문제 설명] 로또의 최고 순위와 최저 순위
// https://school.programmers.co.kr/learn/courses/30/lessons/77484

public class No03
{
    public int[] solution(int[] lottos, int[] win_nums) {
        // 1	6개 번호가 모두 일치
        // 2	5개 번호가 일치
        // 3	4개 번호가 일치
        // 4	3개 번호가 일치
        // 5	2개 번호가 일치
        // 6	그 외
        
        // 6-1 5-2 4-3 3-4 2-5
        // 1-6 0-6
        
        int[] answer = new int[2]; // 최고-최저 순

        int equalCount = 0;
        int zeroCount = 0;

        foreach (int myNum in lottos)
        {
            if (myNum == 0)
            {
                zeroCount++;
                continue;
            }

            foreach (int winNum in win_nums)
            {
                if (myNum == winNum)
                {
                    equalCount++;
                    break;
                }
            }
        }

        answer[0] = Math.Clamp(7 - (equalCount + zeroCount), 1, 6);
        answer[1] = Math.Clamp(7 - equalCount, 1, 6);
        
        return answer;
    }
}

// [다른풀이 - Linq] -> Intersect = lottos 배열과 win_nums 배열의 교집합 구함
// int winCount = lottos.Intersect(win_nums).Count();
