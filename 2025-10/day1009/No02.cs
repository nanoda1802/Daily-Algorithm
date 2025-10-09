namespace Daily_Algorithm._2025_10.day1009;

// [문제 설명] 최소직사각형
// https://school.programmers.co.kr/learn/courses/30/lessons/86491

public class No02
{
    public int solution(int[,] sizes) {
        // 가로세로 말고, 짧은쪽 긴쪽으로 구분, 양 쪽의 최댓값 곱한 게 너비

        int shortMax = 0;
        int longMax = 0;

        for (int i = 0; i < sizes.GetLength(0); i++)
        {
            (int s, int l) = sizes[i, 0] > sizes[i, 1] ? (sizes[i, 1], sizes[i, 0]) : (sizes[i, 0], sizes[i, 1]);
            if (shortMax < s) shortMax = s;
            if (longMax < l) longMax = l;
        }

        return shortMax * longMax;
    }
}

// [메모] 이 문제 탭이 "완전탐색" 인데...?