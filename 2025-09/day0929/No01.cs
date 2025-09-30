namespace Daily_Algorithm._2025_09.day0929;

// [문제 설명] 7의 개수
// https://school.programmers.co.kr/learn/courses/30/lessons/120912

public class No01
{
    public int solution(int[] array) {
        int answer = 0;
        int num;

        foreach (int i in array)
        {
            num = i;
            
            while (num != 0)
            {
                if (num % 10 == 7) answer += 1;
                num /= 10;
            }
        }
        
        return answer;
    }
}

// [다른풀이1 - 7만 세면 되니까 싹 합쳐버리기]
// return string.Join("", array).Count(x => x == '7');
