namespace Daily_Algorithm._2025_10.day1002;

// [문제 설명] 특이한 정렬
// https://school.programmers.co.kr/learn/courses/30/lessons/120880

public class No02
{
    public int[] solution(int[] numlist, int n)
    {
        // n과 가까운 수부터 정렬
        // 거리가 같다면 더 큰 수가 앞

        // numlist[i] - n

        int[] answer = new int[numlist.Length];
        int[] differs = new int[numlist.Length];

        for (int i = 0; i < differs.Length; i++)
        {
            differs[i] = numlist[i] - n;
        }

        Sort(differs);

        for (int i = 0; i < differs.Length; i++)
        {
            answer[i] = differs[i] + n;
        }

        return answer;
    }

    private void Sort(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 0; j < arr.Length - 1 - i; j++)
            {
                int differAbs = Math.Abs(arr[j]) - Math.Abs(arr[j + 1]);

                if (differAbs > 0 || (differAbs == 0 && arr[j] < arr[j + 1]))
                {
                    (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                }
            }
        }
    }
}

// [다른풀이1 - Linq]
// numlist.OrderBy(x => Math.Abs(x - n)).ThenByDescending(x => x).ToArray();
// Orderby는 동일 값들을 묶어 정렬(같은 값 기준 key로 설정) 예를 들어 Math.Abs(x-n)들이 1,-2,2,3,4가 됐다면, 1:(1), 2:(-2,2), 3:(3), 4:(4)로 정렬이 된다는 것
// Thenby는 각 묶음마다 적용하는 정렬 => key가 2인 그룹이 두개니까 얘네를 내림차순으로 재정렬 2:(2,-2)

// [다른풀이2 - Comparer] -> 문제 조건에 맞도록 IComparer를 상속받는 클래스 만들어 Compare 메서드 구현
// Array.Sort(numlist, new ClosestComparer(n)); 