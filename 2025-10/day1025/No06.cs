namespace Daily_Algorithm._2025_10.day1025;

// 다음 큰 숫자
// https://school.programmers.co.kr/learn/courses/30/lessons/12911

// 1. N은 n보다 큰 자연수
// 2. N과 n을 2진수로 변환했을 때, 1의 개수가 동일
// 3. N은 1번과 2번을 만족하는 최솟값

// 11111 -> 101111

// 11110 -> 100111

// 11101 -> 11110 
// 11011 -> 11101
// 10111 -> 11011

// 11100 -> 100011

// 11010 -> 11100
// 11001 -> 11010
// 10110 -> 11010
// 10101 -> 10110
// 10011 -> 10101

// 11000 -> 100001

// 10100 -> 11000
// 10010 -> 10100
// 10001 -> 10010

// 10000 -> 100000

// 제일 뒤의 01쌍을 찾음, 둘이 자리 바꿈
// 쌍 뒤에 1이 있다면 뒤로 밀착시킴
// 01쌍 없다면? 두번째 자리에 0 삽입 후 그 뒤의 1들 뒤로 밀착

// 일단 내일 하자?//////////ㅁㄴㅇㄻㄴㅇㄻㄴㅇㄹ
// 비트 연산으로 푸는? 듯?


public class No06
{  
    public int solution(int n) 
    {
        string bin = Convert.ToString(n, 2);
        int idx = bin.LastIndexOf("01");

        string front = "";
        string back = "";
        
        Console.WriteLine(bin);
        
        if (idx >= 0)
        {
            for (int i = 0; i <= idx; i++)
            {
                if (i == idx) front += bin[i + 1];
                front += bin[i];
            }

            idx += 2;
        }
        else
        {
            front = "10";
            idx = 1;
        }
        
        // a+1번 인덱스부터 끝까지의 범위를 체크, 1을 뒤로 밀착
        int width = bin.Length - idx;
        if (width > 0)
        {
            back = bin.Substring(idx + 1).Replace("1", "").PadRight(width, '1');
        }
        Console.WriteLine(front + "/" + back);
        return Convert.ToInt16(front + back,2);
    }
}