namespace Daily_Algorithm._2025_10.day1015;

// [문제 설명] 기사단원의 무기
// https://school.programmers.co.kr/learn/courses/30/lessons/136798

public class No01
{
    public int solution(int number, int limit, int power) {
        // number의 약수를 구함
        // limit과 비교함
        // 더 크면 power로 대체
        // 아니면 약수 개수대로
    
        int answer = 0;

        for (int i = 1; i <= number; i++)
        {
            int atk = 0;
            bool isPow =  false;
    
            for (int j = 1; j*j <= i; j++)
            {
                if (i % j == 0)
                {
                    atk += 1;
                    isPow = j*j == i;
                }
            }
    
            atk = isPow ? atk * 2 - 1 : atk * 2;
    
            answer += atk > limit ? power : atk;    
        }
    
        return answer;
    }
}
