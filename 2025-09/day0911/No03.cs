namespace Daily_Algorithm._2025_09.day0911;

// [문제 설명] 1로 만들기
// https://school.programmers.co.kr/learn/courses/30/lessons/181880

public class No03
{
    public int Print(int[] num_list) {
        // 짝수라면 나누기 2
        // 홀수라면 1 빼고 나누기 2
        // "반복"하면 결국 1에 도착
        // 배열의 모든 원소를 1로 만들기 위한 나누기 반복 횟수 구하기

        int sum = 0;

        for (int i = 0; i < num_list.Length; i++)
        {
            if (num_list[i] == 1) continue;
            sum += divideToOne(num_list[i]);
        }
        
        return sum;
    }

    private int divideToOne(int num, int divideCount=0)
    {
        int result = num % 2 == 0 ? num / 2 : (num - 1) / 2;
        divideCount += 1;
        return result == 1 ? divideCount : divideToOne(result, divideCount);
    }
}

// [메모] 순서 상관 없으니 foreach로 푸는 걸 권장하나 보네 