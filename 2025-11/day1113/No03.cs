namespace Daily_Algorithm._2025_11.day1113;
// 두 큐 합 같게 만들기
// https://school.programmers.co.kr/learn/courses/30/lessons/118667

// [이 문제의 핵심]
// 1. 두 큐에서 원소를 옮기는 건 순환 형태 -> 아무리 옮겨도 전체 순서는 유지가 됨!
//   무한정 옮기다 보면 초기 상태로 회귀하기 때문에, "적정 반복 횟수"가 존재
// 2. 어디서 넣을지 뺄지 -> 탐욕법 활용
//    "당장" 목표보다 작다? 그럼 받아오고, 크다? 그럼 뽑아주고 

public class No03
{
    public int solution(int[] queue1, int[] queue2) {
        int len = queue1.Length;
        Queue<int> q1 = new Queue<int>();
        Queue<int> q2 = new Queue<int>();
        long sum1 = 0; 
        long sum2 = 0;
        for (int i = 0; i < len; i++)
        {
            sum1 += queue1[i];
            sum2 += queue2[i];
            q1.Enqueue(queue1[i]);
            q2.Enqueue(queue2[i]);
        }

        if ((sum1 + sum2) % 2 != 0) return -1;

        long target = (sum1 + sum2) / 2;
        int cnt = 0;
        while (cnt < len*3)
        {
            if (sum1 < target)
            {
                int e = q2.Dequeue();
                sum1 += e;
                q1.Enqueue(e);
            }
            else if (sum1 > target)
            {
                int e = q1.Dequeue();
                sum1 -= e;
                q2.Enqueue(e);
            }
            else return cnt;
            cnt++;
        }
        
        return -1;
    }
    
    public int solution2(int[] queue1, int[] queue2) {
        int len = queue1.Length;
        Queue<int> q1 = new Queue<int>();
        Queue<int> q2 = new Queue<int>();
        long sum1 = 0; 
        long sum2 = 0;
        for (int i = 0; i < len; i++)
        {
            sum1 += queue1[i];
            sum2 += queue2[i];
            q1.Enqueue(queue1[i]);
            q2.Enqueue(queue2[i]);
        }

        if ((sum1 + sum2) % 2 != 0) return -1;

        long target = (sum1 + sum2) / 2;
        int cnt = 1; // 여기가 달랐어......... 그래서 이미 같은 경우에 1을 반환해서 2번과 29번을 실패했던 것
        while (cnt < len*3)
        {
            if (sum1 < target)
            {
                int e = q2.Dequeue();
                sum1 += e;
                q1.Enqueue(e);
            }
            else if (sum1 > target)
            {
                int e = q1.Dequeue();
                sum1 -= e;
                q2.Enqueue(e); 
            }

            if (sum1 == target) return cnt;
            cnt++;
        }
        
        return -1;
    }
}

        
// [실패! 오답 + 시간초과]
// half가 되려면 a개 주고, b개 받아야 하는지 -> a+b 가 답
// 235512 - 664132 (18-22) (반:20)
// 2 5 "10" 15 16 18 (a=3)
// 6 "12" 16 17 20 22 (b=2)
// 51266 - 4132235 (20-20)
/*
int len = queue1.Length;
        
long sum1 = 0;
foreach (int i in queue1) sum1 += i;
long total = sum1;
foreach (int i in queue2) total += i;

if (total % 2 != 0) return -1;
        
for (int i1 = 0; i1 < len; i1++)
{
    long temp = sum1 -= queue1[i1];
    int i2 = 0;
    while (temp < total/2) temp += queue2[i2++];
    if (temp == total/2) return (i1+1)+i2;
}
        
return -1;
*/
/*
int len = queue1.Length;
        
long[] prefixSum1 = new long[len];
prefixSum1[0] = queue1[0];
long[] prefixSum2 = new long[len];
prefixSum2[0] = queue2[0];
        
for (int i = 1; i < len; i++)
{
    prefixSum1[i] = queue1[i] + prefixSum1[i - 1];
    prefixSum2[i] = queue2[i] + prefixSum2[i - 1];
}
        
if ((prefixSum1[len-1] + prefixSum2[len-1]) % 2 != 0) return -1;
        
long target = (prefixSum1[len-1] + prefixSum2[len-1]) / 2 - prefixSum1[len-1];

for (int i = 0; i < len; i++)
{
    for (int j = 0; j < len; j++)
    {
        if (target == prefixSum2[j]-prefixSum1[i])
        {
            return i + j + 2;
        }
    }
}

return -1;
*/

// [실패 오답 + 시간초과]
// 슬라이딩윈도우?
// 윈도우 크기 늘려가며...
// 윈도우 크기가 len부터 1씩 감소 (len을 넘으면 이미 확인한 케이스)
// 윈도우가 이동하며 합 확인 => 합이 total의 절반일 때 반환
/*
int len = queue1.Length;
long total = 0;
int[] arr = new int[len * 2];
for (int i = 0; i < len; i++) total += arr[i] = queue1[i];
for (int i = 0; i < len; i++) total += arr[i + len] = queue2[i];

if (total % 2 != 0) return -1;
        
for (int size = len; size >= 1; size--)
{
    long sum = 0;
    for (int i = 0; i < size; i++) sum += arr[i];
    if (sum == total / 2) return 0;

    for (int i = 0; i < len; i++)
    {
        sum += arr[(i+size)%len] - arr[i];
        if (sum == total / 2) return 0;
    }
}

return -1;
*/