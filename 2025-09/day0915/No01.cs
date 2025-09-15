namespace Daily_Algorithm._2025_09.day0915;

// [문제 설명] 배열의 길이를 2의 거듭제곱으로 만들기
// https://school.programmers.co.kr/learn/courses/30/lessons/181857

public class No01
{
    public int[] Print(int[] arr)
    {
        // [1] 기존 길이와 새 길이 변수 선언
        int oldLen = arr.Length;
        int newLen = 0;
        
        // [2] 기존 길이에 따라 분기 구분
        if (oldLen > 1)
        {
            // [A-1] 지수 확인 위한 연산횟수 변수
            int operCount = 0;
            
            // [A-2] 기존 길이가 1일 될 때까지 2로 나누는 동안 발생한 부산물의 합
            // 부산물 : 나머지가 1인 연산 때, 2의 operCount승
            int remainders = DivideByTwo(oldLen, ref operCount);
            
            // [A-3] 기존 배열이 이미 조건에 부합하므로 바로 반환 
            if (remainders == 0) return arr;
            
            // [A-4] 새 길이 계산 (기존 길이보다 크거나 같은 2의 거듭제곱수 중 최소값)
            newLen = (oldLen - remainders) * 2;
        }
        else if (oldLen == 1)
        {
            // [B-1] 2의 0승이 1이기 때문에 조건에 부합, 바로 반환 
            return arr;
        } 
        else if (oldLen == 0)
        {
            // [C-1] 기존 배열이 비었다면 길이가 1인 { 0 } 만들어 반환
            return new int[] { 0 };
        }

        // [3] 새 배열 생성
        int[] answer = new int[newLen];
        
        // [4] 전부 0으로 채워두고, 기존 배열 복사해 덧붙이기
        Array.Fill(answer, 0);
        Array.Copy(arr,answer,oldLen);
        
        // [5] 결과 반환
        return answer;
    }
    
    private int DivideByTwo(int num, ref int operCount, int sum = 0)
    {
        int quotient = num / 2; // 몫
        int remainder = num % 2; // 나머지
        
        if (remainder == 1) sum += Power(2, operCount);
        
        operCount += 1;
        
        // 몫이 1이 될 때까지 재귀
        return quotient == 1 ? sum : DivideByTwo(quotient, ref operCount, sum);
    }

    private int Power(int baseNum, int powNum)
    {
        if (baseNum == 0) return 0;
        if (powNum == 0) return 1;
        if (powNum == 1) return baseNum;

        int result = baseNum;
        
        for (int i = 1; i < powNum; i++) result *= baseNum;

        return result;
    }
}

// [다른풀이 1 - 길이 기준 찾기 x 거듭제곱수 기준으로 찾기 O]
/*
    int size = 1;
    while(size < arr.Length)   <- 기존 길이보다 큰 최소 길이
        size *= 2;
    
    int[] answer = new int[size];
    Array.Copy(arr, 0, answer, 0, arr.Length);
    return answer;
*/

// [다른풀이 2 - int[]의 빈 요소의 default는 어차피 0이다]
/*
    int size = 1;
    while(size < arr.Length)
    {
        size *= 2;
    }
    Array.Resize(ref arr, size);
    return arr;
*/

// [메모] DivideByTwo 예시 (풀이 원리)

//  [1] 17에 DivideByTwo()
//  1회 : 8 / 1 (2의 0승)
//  2회 : 4 / 0
//  3회 : 2 / 0
//  4회 : 1 / 0
//  [ 17 = 2의 4승 + 1 ] => 1 빼고 2 곱하면 32
   
//  [2] 37에 DivideByTwo()
//  1회 : 18 / 1 (2의 0승)
//  2회 : 9 / 0
//  3회 : 4 / 1 (2의 2승)
//  4회 : 2 / 0 
//  5회 : 1 / 0
//  [ 2의 5승 + (1 + 4) ] => 5 빼고 2 곱하면 64 