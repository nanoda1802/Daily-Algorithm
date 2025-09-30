namespace Daily_Algorithm._2025_09.day0930;

// [문제 설명] 저주의 숫자 3
// https://school.programmers.co.kr/learn/courses/30/lessons/120871

public class No04
{
    public  int solution(int n) {
        // n에서 n 보다 작거나 같은 3의 배수 개수를 더함
        // ( n ) + ( n이하 3배수 개수 )
        
        // 가 아니고 13, 133 이딴 애들도 빼야함...

        List<int> townNums = new List<int>();

        int i = 1;
        
        while (townNums.Count <= n)
        {
            if (!(i % 3 == 0 || (i+"").Contains('3'))) townNums.Add(i);
            i += 1;
        }

        return townNums[n - 1];
    }
}