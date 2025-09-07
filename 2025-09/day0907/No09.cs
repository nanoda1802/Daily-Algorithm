namespace Daily_Algorithm._2025_09.day0907;

// [문제 설명] 9로 나눈 나머지
// https://school.programmers.co.kr/learn/courses/30/lessons/181914

public class No09
{
    public int Print(string number)
    {
        char[] arr = number.ToCharArray();
        
        int sum = 0;

        Console.WriteLine(arr.Length);
        
        foreach (char c in arr)
        {
            sum += int.Parse(c+"");
        }
        
        return sum % 9;
    }
}

// [다른풀이1 - 유니코드]
// return number.Select(s => s - '0').Sum() % 9; <- 숫자 형태의 string에 char 타입 0을 빼주면 int 타입으로 반환하나보다