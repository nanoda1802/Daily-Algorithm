using System.Text;

namespace Daily_Algorithm._2025_10.day1002;

// [문제 설명] 이진수 더하기
// https://school.programmers.co.kr/learn/courses/30/lessons/120885

public class No06
{
    public string solution(string bin1, string bin2) {
        // 뒤에서부터 와야함
        
        StringBuilder answer = new StringBuilder();

        int longLen = Math.Max(bin1.Length, bin2.Length);

        bin1 = bin1.PadLeft(longLen, '0');
        bin2 = bin2.PadLeft(longLen, '0');

        int up = 0;
        int sum = -1;
        
        for (int i = longLen-1; i >= 0; i--)
        {
            sum = (bin1[i] - '0') + (bin2[i] - '0') + up;

            switch (sum)
            {
                case 0:
                    answer.Insert(0, "0");
                    up = 0;
                    break;
                case 1:
                    answer.Insert(0, "1");
                    up = 0;
                    break;
                case 2:
                    answer.Insert(0, "0");
                    up = 1;
                    break;
                case 3: 
                    answer.Insert(0, "1");
                    up = 1;
                    break;
            }
        }

        if (up == 1) answer.Insert(0, "1");

        Convert.ToString(Convert.ToInt32(bin1, 2) + Convert.ToInt32(bin2, 2), 2);
        
        return answer.ToString();
    }
}

// [다른풀이1 - Convert 클래스] -> base 개념이 있어서 변환 기준 진법을 구할 수 있음, 2 8 10 16 만 가능 
// return Convert.ToString(Convert.ToInt32(bin1, 2) + Convert.ToInt32(bin2, 2), 2);