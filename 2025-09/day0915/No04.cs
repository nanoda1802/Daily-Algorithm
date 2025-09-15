namespace Daily_Algorithm._2025_09.day0915;

// [문제 설명] 뒤에서 5등까지
// https://school.programmers.co.kr/learn/courses/30/lessons/181853

public class No04
{
    public int[] Print(int[] num_list) {
        // 가장 작은 5개 수를 오름차순으로 담은 배열 반환
        // 오름차순으로 정렬한 다음 앞에서 5개...
        // Array 메서드 쓰나 Linq 쓰나... 그냥 Linq 혀
        // 하지만 퀵소트 해보기로 했다...
        
        // 일단 제출용 -> Order를 못 하셔서 결국 들다 했넹...
        // 아니 OrderBy는 왜 되는 거임...?
        return num_list.Order().Take(5).ToArray();
    }

    private void Swap(int[] arr, int idx1, int idx2)
    {
        // ?! 일단 ValueTuple인데 이거;;
        // 분해할당으로 배열 요소 위치 변환이 쉽게 된다네!
        (arr[idx1], arr[idx2]) = (arr[idx2], arr[idx1]);
    }

    private int Partition(int[] arr, int beginIdx, int endIdx)
    {
        // [1] 뒤 요소를 피벗으로 설정
        int pivotValue = arr[endIdx];
        
        // [2] 시작 위치 한 칸 앞을 초기 바꿀 위치로 지정 
        int idxToSwap = beginIdx - 1;

        // [3] 앞 요소부터 뒤 요소 사이 순회
        for (int currentIdx = beginIdx; currentIdx < endIdx; currentIdx++)
        {
            // [Loop-1] 현재 요소가 피벗보다 작거나 같으면
            if (arr[currentIdx] <= pivotValue)
            {
                // [Loop-2] 바꿀 위치 뒤로 한 칸
                idxToSwap += 1;
                // [Loop-3] 바꿀 인덱스와 현재 인덱스 요소 바꾸기
                Swap(arr,idxToSwap,currentIdx);
            }
        }
        
        // [4] 피벗까지 적정 위치와 바꾸기 (순회 마친 피벗의 적정 위치는 마지막 바꿀 위치 다음 칸)
        Swap(arr, idxToSwap + 1, endIdx);
        
        // [5] 이번 피벗의 인덱스 반환 (현상태 : 피벗위치 기준, 앞은 피벗 이하, 뒤는 피벗 이상 요소들 위치)
        return idxToSwap + 1;
    }

    private void QuickSort(int[] arr)
    {
        QuickSort(arr,0,arr.Length-1);
    }
    
    private void QuickSort(int[] arr, int lowIdx, int highIdx)
    {
        if (lowIdx < highIdx)
        {
            int pivotIdx = Partition(arr, lowIdx, highIdx);
            
            QuickSort(arr,lowIdx,pivotIdx-1);
            QuickSort(arr,pivotIdx+1,highIdx);
        }
    }
}