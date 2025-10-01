namespace Daily_Algorithm._2025_10.day1001;

// [문제 설명] 유한소수 판별
// https://school.programmers.co.kr/learn/courses/30/lessons/120878

public class No03
{
    public int solution(int a, int b) {
        List<int> aNums = new List<int>(); 
        List<int> bNums = new List<int>(); 
        
        PrimeFactorize(a,aNums);
        PrimeFactorize(b,bNums);

        foreach (int bNum in bNums)
        {
            if (bNum != 2 && bNum != 5)
            {
                if(!aNums.Contains(bNum)) return 2;

                aNums.Remove(bNum);
            }
        }

        return 1;
    }

    private void PrimeFactorize(int n, List<int> list)
    {
        int num = n;
        
        while (num % 2 == 0)
        {
            list.Add(2);
            num /= 2;
        }

        for (int i = 3; i <= n; i+=2)
        {
            while (num % i == 0)
            {
                list.Add(i);
                num /= i;
            }
            
            if (num == 1) break;
        }
    }
}

// <소인수 분해>
// [1] 2로 나누기: 먼저, 입력받은 수 n을 2로 나누어 떨어지는지 확인합니다.
// [2] 소수 찾기: 2로 나누어떨어지면 2를 소인수로 기록하고, 몫을 다시 n에 저장합니다. 이 과정을 2로 더 이상 나누어떨어지지 않을 때까지 반복합니다.
// [3] 홀수로 나누기: 2로 더 이상 나누어떨어지지 않으면, 3부터 시작하여 홀수 i로 나누어떨어지는지 확인합니다.
// [4] 반복: i로 나누어떨어지면 i를 소인수로 기록하고 몫을 n에 저장하며, i로 더 이상 나누어떨어지지 않을 때까지 반복합니다.
// [5] 반복 종료: n이 1이 될 때까지 이 과정을 반복합니다.


// [다른풀이1 - 분모만 확인하면 됨]
/*
    int answer = 1;
    while(b % 2 == 0) b /= 2;
    while(b % 5 == 0) b /= 5;
    if(a % b != 0) answer = 2;
    return answer;
*/
// 1. 분모에서 2와 5인 소인수를 전부 없앰
// 2. 남은 소인수로 분자와 만났을 때 약분 되는 지 확인
// 3. 안된다 = 조건에 맞지 않는 소인수가 있다 => 2 반환
// 4. 된다 => 1 반환