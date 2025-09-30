namespace Daily_Algorithm._2025_09.day0929;

// [문제 설명] 직사각형 넓이 구하기
// https://school.programmers.co.kr/learn/courses/30/lessons/120860

public class No03
{
    public int solution(int[,] dots) {
        int x1=-256;
        int x2=-256;
        int y1=-256;
        int y2=-256;

        for (int i = 0; i < dots.GetLength(0); i++)
        {
            int curX = dots[i, 0];

            if (curX != x1 && curX != x2)
            {
                if (curX >= x2)
                {
                    x1 = x2;
                    x2 = curX;
                }
                else if (curX >= x1) x1 = curX;
            }

            int curY = dots[i, 1];

            if (curY != y1 && curY != y2)
            {
                if (curY >= y2)
                {
                    y1 = y2;
                    y2 = curY;
                }
                else if (curY >= y1) y1 = curY;
            }
        }

        return (x2 - x1) * (y2 - y1);
    }
}