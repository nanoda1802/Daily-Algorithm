namespace Daily_Algorithm._2025_09.day0914;

// [문제 설명] 무작위로 K개의 수 뽑기
// https://school.programmers.co.kr/learn/courses/30/lessons/181858

public class No04
{
    public int[] Print(int[] arr, int k) {
        // answer의 capacity = k
        // arr 순회 : arr[i]가 answer에 없으면 추가, 있으면 패스
        // 순회 중 answer 꽉참 -> break
        // 순회 다 했는데 answer 용량 남음 -> -1로 채우기
        
        
        // 그냥 distinct 한 담에, Take(k)
        IEnumerable<int> temp = arr.Distinct().Take(k);
        
        int diff = k - temp.Count();
        
        if (diff > 0)
        {
            for (int i = 0; i < diff; i++)
            {
                temp = temp.Append(-1);
            }
        }

        return temp.ToArray();
    }
}

// [다른풀이1 - 씽크빅]
// int[] answer = Enumerable.Repeat(-1,k).ToArray();
// 미리 answer를 k만큼 -1로 채워놓는 겨
// 그럼 꽉 차면 알아서 갱신되고, 모자르면 알아서 나머지 -1이고!
// 여긴 Linq로 채웠지만, 그냥 반복문으로 채워도 되자나 