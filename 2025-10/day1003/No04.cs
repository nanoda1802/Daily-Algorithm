namespace Daily_Algorithm._2025_10.day1003;

// [문제 설명] 다음에 올 숫자
// https://school.programmers.co.kr/learn/courses/30/lessons/120924

public class No04
{
    public int solution(int[] common) {
        // 중간 수에 접근해 앞뒤 비교 -> 등차인지 등비인지 확인 + 공차와 공비 구하기
        // 마지막 수에 공차 더하거나 공비 곱하기 끗
        
        int middle = (common.Length-1)/2; // 인덱스가 될 거라 +1 하면 안 되넹

        int prev = common[middle - 1];
        int cur = common[middle];
        int next = common[middle + 1];

        if (prev + cur + next == 3 * cur)
        {
            return common[common.Length - 1] + next - cur;
        }
        
        if (prev * cur * next == cur * cur * cur)
        {
            return common[common.Length - 1] * (next / cur);
        }
        
        return 0;
    }
}

// [메모] 굳이 중간값 아니어도 처음 세 요소 0,1,2 로 확인해도 같은 결과임!

// [메모] 조건식 더 단순화 할 수 있었넹... 수학적으로 생각하기...
// prev + next == 2 * cur
// prev * next == cur * cur
