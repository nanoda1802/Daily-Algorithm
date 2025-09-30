namespace Daily_Algorithm._2025_09.day0930;

// [문제 설명] 삼각형의 완성조건 2
// https://school.programmers.co.kr/learn/courses/30/lessons/120868

public class No02
{
    public  int solution(int[] sides) {
        // 가장 긴 변의 길이 < 다른 두 변 길이의 합
        
        // 1) c는 a나 b보단 크면서, a+b 보다 작은 값
        // 2) c는 Max(a,b) 보단 작으면서, Max(a,b) - Min(a,b) 보다 크거나 같은 값
        
        int answer = 0;
        
        int a = Math.Min(sides[0], sides[1]);
        int b = Math.Max(sides[0], sides[1]);

        for (int i = b+1 ; i < a+b; i++)
        {
            answer += 1;
        }

        for (int i = b-a; i < b; i++)
        {
            answer += 1;
        }
        
        return answer;
    }
}

// [다른풀이1 - min * 2 -1이 된 이유] -> 접근은 똑같다... ㅠㅠ 아쉽
/*
    max = 주어진 두 변 중 긴 한 변
    min = 주어진 두 변 중 짧은 한 변
    
    case1: 주어진 두 변의 길이 중 하나가 가장 긴 변일 경우
        max < min + (다른 한 변)
        max - min < (다른 한 변)
    
    case2: 주어진 두 변 외에 다른 긴 변이 있는 경우
        (다른 한 변) < max + min
    
    두 케이스를 조합하면
    max - min < (다른 한 변) < max + min 이므로
    (다른 한 변)이 나올 수 있는 가짓수는
    (max + min) - (max - min) - 1 => min * 2 - 1 입니다
*/