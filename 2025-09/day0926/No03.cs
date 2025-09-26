namespace Daily_Algorithm._2025_09.day0926;

// [문제 설명] 가까운 수
// https://school.programmers.co.kr/learn/courses/30/lessons/120890

public class No03
{
    public int solution(int[] array, int n) {
        int[] differs = new int[array.Length];
        int minDiffer = 100;
        for (int i = 0; i < array.Length; i++)
        {
            differs[i] = Math.Abs(array[i] - n);
            if (minDiffer > differs[i]) minDiffer = differs[i];
        }
        
        List<int> minIdx = new List<int>();
        for (int i = 0; i < array.Length; i++)
        {
            if(array[i] - n == minDiffer || array[i] - n == -minDiffer) minIdx.Add(i);
        }
        
        int minNum = 100;
        foreach (int i in minIdx)
        {
            if (minNum > array[i]) minNum = array[i];
        }

        return minNum;
    }
}