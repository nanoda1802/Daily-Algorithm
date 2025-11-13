namespace Daily_Algorithm._2025_11.day1113;
// 두 개 이하로 다른 비트
// https://school.programmers.co.kr/learn/courses/30/lessons/77885

// f(x) = x보다 크고 x와 비트가 1~2개 다른 수들 중에서 제일 작은 수  
// numbers 모든 수들에 대하여 각 수의 f 값을 배열에 차례대로 담아 return
// 0 ≤ numbers의 모든 수 ≤ 10^15  

// 해설 https://school.programmers.co.kr/questions/74664  
// [풀이1] if ((num & bin) == 0)  
// &은 두 자리가 모두 1인 비트만 1을 반환  
// bin은 2의 지수기 때문에 1, 10, 100, 1000, ... 처럼 단 하나의 비트만 1을 가짐  
// 즉, bin과 비교한다면 특정 비트만 확인이 가능하고,  
// num의 특정 비트가 1이라면 &연산 결과는 1, 10, 100, 등 bin과 같은 값이 나오겠지만,  
// 0이라면 무조건 0인 결과가 나옴 => num의 비트 중 가장 처음의 0을 찾을 수 있게 됨!  
  
// [풀이2] num |= bin;  
// 찾은 0을 1로 바꿔줘야 함!  
// bin은 특정 비트 제외하곤 모두 0이기 때문에,  
// OR 연산 시 해당 자리 제외하곤 num의 비트에 영향을 미치지 않음  
// bin은 딱 해당 위치만 1이기 때문에, 저 연산의 결과는 num에서 찾은 0만 1로 변한 값이 됨  
  
// [풀이3] num ^= (bin / 2);  
// 처음 찾은 0위치의 바로 전 위치는 1이겠지?  
// 여길 0으로 바꿔야하기 때문에, XOR 연산을 활용  
// XOR 연산은 두 비트가 같다면 0, 다르면 1을 반환하기 때문에,  
// 바로 전 위치의 비트만 1인 수를 num과 연산해줘야 함!  
// 그 수가 바로 0을 찾은 bin에 2를 나눈 수!  
// 예를 들어 bin이 8 (1000) 이었다면 네번째 비트가 0이니까,  
// 세번째 비트를 바꾸기 위해 100이 필요하고, 2를 나눈 4가 바로 100! 
 
// [풀이4] bin *= 2;  
// num의 각 비트를 비교하기 위해 자리수를 이동  
// bin이 1로 시작해 2, 4, 8, 16, ... 으로 늘어가는 것  
// => 1로 시작해 10, 100, 1000, 10000, ... 으로 비트가 변해가는 것  

public class No02
{
    public long[] solution(long[] numbers) {  
        long[] answer = new long[numbers.Length];  
  
        for (int i = 0; i < numbers.Length; i++)  
        {        
            long num = numbers[i];  
            long bin = 1;  
            while (true)  
            {            
                if ((num & bin) == 0)  
                {                
                    num |= bin;               
                    num ^= (bin / 2);  
                    break;  
                }           
                bin *= 2;  
            }                
            answer[i] = num;  
        }    
        return answer;  
    }
}

