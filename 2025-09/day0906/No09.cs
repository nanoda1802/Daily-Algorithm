namespace Daily_Algorithm._2025_09.day0906;

// [문제 설명] 수열과 구간 쿼리 3
// https://school.programmers.co.kr/learn/courses/30/lessons/181924

public class No09
{
    public int[] Print(int[] arr, int[,] queries)
    {
        int[] answer = new int[arr.Length];
        Array.Copy(arr, answer, arr.Length);
        
        for (int n = 0; n < queries.GetLength(0); n++) 
        {
            int i = queries[n, 0]; 
            int j = queries[n, 1];
            
            TradeElement(ref answer, i, j);
        }
        
        return answer;
    }

    private void TradeElement(ref int[] arr, int i, int j)
    {
        int tempI = arr[i];  
        int tempJ = arr[j];
        
        arr[i] = tempJ;
        arr[j] = tempI;
    }
}

// [메모]
// - 2차원배열은 그냥 Length로 하면 전체 요소 개수 뱉음 ([[0, 3],[1, 2],[1, 4]] 기준 6을 반환...) 
// - 반복문 안에서 변수 만들면 매번 메모리 공간 찾고 값 초기화하고... -> 선언은 밖에서 하고 할당만 반복문 안에서 하기!