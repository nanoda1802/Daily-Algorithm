namespace Daily_Algorithm._2025_09.day0922;

// [문제 설명] 개미군단
// https://school.programmers.co.kr/learn/courses/30/lessons/120837

public class No07
{
    public int solution(int hp) {
        // 개미군단의 총 공격력 = 사냥감 체력
        // 최소 개미 수
        // 장군 5, 병정 3, 일 1
        
        int answer = 0;
        
        // 5로 나누기
        // cnt에 몫 더하기, 나머지 발생?
        // 나머지 3으로 나누기
        // cnt에 몫 더하기, 나머지 발생?
        // cnt에 나머지 더하기

        answer += hp / 5;
        int of5 = hp % 5;
        if (of5 == 0) return answer;

        answer += of5 / 3;
        int of3 = of5 % 3;
        if (of3 == 0) return answer;
        
        return answer + of3;
    }
}