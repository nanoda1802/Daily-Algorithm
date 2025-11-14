namespace Daily_Algorithm._2025_11.day1114;
// 쿼드 압축 후 개수 세기
// https://school.programmers.co.kr/learn/courses/30/lessons/68936

// 첫 분할 크기 : row / 2
// 각 구역 확인...
// 분할 크기 나누기 2 하고 병합되지 않은!! 각 구역에 또 실행
// 분할 크기 1되면 그만

// 01234567
// 0123 4567
// 01 23 45 67
// 0 1 2 3 4 5 6 7

// 맘에 들지 않음림나어리ㅏㄷㅁ

public class No01
{
    public int[] solution(int[,] arr) {
        int[] answer = new int[2];
        Compress(arr,answer,0,0,arr.GetLength(0));
        return answer;
    }
 
    private void Compress(int[,] arr, int[] ans, int x, int y, int size)
    {
        int start = arr[y,x];
        bool flag = true;
        for (int i = y; i < y+size; i++)
        {
            for (int j = x; j < x+size; j++)
            {
                if (start != arr[i, j])
                {
                    flag = false;
                    break;
                }
            }
        }
        
        if (flag) ans[start]++;
        else
        {
            size /= 2;
            if (size < 1) return;
            Compress(arr, ans, x, y, size);
            Compress(arr, ans, x+size, y, size);
            Compress(arr, ans, x, y+size, size);
            Compress(arr, ans, x+size, y+size, size);
        }
    }
}

