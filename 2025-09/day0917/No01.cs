namespace Daily_Algorithm._2025_09.day0917;

// [문제 설명] 날짜 비교하기
// https://school.programmers.co.kr/learn/courses/30/lessons/181838

public class No01
{
    public int Print(int[] date1, int[] date2)
    {
        for (int i = 0; i < date1.Length; i++)
        {
            if (date1[i] == date2[i]) continue;

            return date1[i] < date2[i] ? 1 : 0;
        }

        return 0;
    }
}

// [다른풀이1 - 타입 변환]
// int 또는 DateTime으로 바꿔서 대소 비교