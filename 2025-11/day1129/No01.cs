namespace Daily_Algorithm._2025_11.day1129;
// 테이블 해시 함수
// https://school.programmers.co.kr/learn/courses/30/lessons/147354

// 다른 언어는 딸깍으로 하는데 왜 Linq 똥꼬쑈를 해야 하는ㅇㄻㄴㅇ리ㅏ

/* OrderBy와 ThenBy */
// Descending이 있고 없고로 정렬순서가 정해져있음
// 요구하는 람다는 KeySelector로, 정렬의 key가 돼줄 녀석을 골라주면 됨
// 본 문제에선 col열의 값 또는 기본키인 1열의 값이었기 때문에,
// (tuple => tuple[col - 1]) 과 (tuple => tuple[0]) 을 활용

/* Skip과 Take */
// skip은 count개를 건너뛰고 나머지 요소들을 가져옴
// 총 6가지 요소가 있는 배열에 Skip(2)를 한다면,
// 0과 1번 인덱스는 건너뛰고 "2번 인덱스"부터 나머지 네 요소를 가져옴!
// take는 맨 앞에서부터 count개의 요소들을 가져옴
// 총 6가지 요소가 있는 배열에 Take(2)를 한다면,
// 0과 1번 인덱스만 가져오고, 나머지 요소들은 버림!

/* Select */
// JAVA 스트림의 map과 같은 녀석
// 콜렉션의 요소들을 특정 규칙에 맞게 변환해줌!
// 요구하는 람다는 Selector로, 변환할 규칙을 지정해주면 됨
// 본 문제에선 "특정 행의 모든 요소에 나머지 연산을 가한 합"으로 변환시켰음
// 또 예를 들어 int[] 타입을 요소로 갖는 배열 A에
// A.Select(arr => arr.Length)를 하면,
// A 배열은 원래 배열들의 길이에 해당하는 int 타입을 요소로 갖도록 변함! 

/* Aggregate */
// JAVA 스트림과 Javascript의 Reduce와 같은 녀석
// 대개 cur, next를 매개변수로 삼아 특정 연산의 누적 결과를 반환함!
// 현재 인덱스의 요소와 다음 인덱스의 요소로 연산 후,
// 그 연산 결과와 그 다음 인덱스의 요소와 연산, ....
// 요구하는 람다는 Func로, 누적할 연산을 정의해주면 됨!
// 가장 간단한 버전으론 Aggregate((c,n) => c+n) 으로, 누적합이 이씀

public class No01
{
    public int solution(int[,] data, int col, int row_begin, int row_end) {
        List<List<int>> table = new List<List<int>>();
        for (int i = 0; i < data.GetLength(0); i++)
        {
            table.Add(new List<int>());
            for (int j = 0; j < data.GetLength(1); j++)
            {
                table[i].Add(data[i, j]);
            }
        }

        return table.OrderBy(tuple => tuple[col - 1])
            .ThenByDescending(tuple => tuple[0])
            .Skip(row_begin-1)
            .Take(row_end-row_begin+1)
            .Select((tuple, offset) => tuple.Sum(v => v % (row_begin + offset)))
            .Aggregate((cur,next) => cur ^ next);
        
        // 채점 버전이 Take의 인자로 Range를 거부해먹어... 
        return table.OrderBy(tuple => tuple[col-1])
            .ThenByDescending(tuple=>tuple[0])
            .Take(new Range(row_begin-1,row_end))
            .Select((tuple, offset) => tuple.Sum(v => v % (row_begin + offset)))
            .Aggregate((cur,next) => cur ^= next);
    }

    /* 실패 : 시간초과 */
    // 버블정렬이고, 나머지 누적하며 또 반복문이고 등등 예상해씀
    private int solution2(int[,] data, int col, int row_begin, int row_end)
    {
        int len = data.GetLength(0);
 
        for (int i = 0; i < len; i++)
        {
            for (int j = 0; j < len-i-1; j++)
            {
                if (data[j,col-1] < data[j+1,col-1]) continue;
                if (data[j,col-1] == data[j+1,col-1] &&  data[j,0] > data[j+1,0]) continue;
                Swap(data,j,j+1);
            }
        }
        
        int answer = GetS(data, row_begin-1);
        for (int i = row_begin; i < row_end; i++) 
            answer ^= GetS(data, i);
        return answer;
    }
    
    private void Swap(int[,] arr, int i, int j)
    {
        for (int k = 0; k < arr.GetLength(1); k++) 
            (arr[i, k], arr[j, k]) = (arr[j, k], arr[i, k]);
    }

    private int GetS(int[,] arr, int i)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
            sum += arr[i, j] % (i+1);
        return sum;
    }

    private void ShowTable(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write(arr[i, j] + 1 + " ");
            }
            Console.WriteLine();
        }
    }
}

