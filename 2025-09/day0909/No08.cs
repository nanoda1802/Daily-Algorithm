namespace Daily_Algorithm._2025_09.day0909;

// [문제 설명] 배열 조각하기
// https://school.programmers.co.kr/learn/courses/30/lessons/181893

public class No08
{
    public int[] Print(int[] arr, int[] query) {
        int[] answer = arr;
        int[] temp = new int[] { };
        int newLength = 0;

        for (int i = 0; i < query.Length; i++)
        {
            if (i % 2 == 0)
            {
                newLength = query[i] + 1;
                temp = new int[newLength];
                
                for (int j = 0; j <= query[i]; j++)
                {
                    temp[j] = answer[j];    
                }
            }
            else
            {
                newLength = answer.Length - query[i];
                temp = new int[newLength];

                for (int j = query[i]; j < answer.Length; j++)
                {
                    temp[j - query[i]] = answer[j];
                }
            }
            
            answer = new int[newLength];
            Array.Copy(temp,answer,newLength);
        }
        
        return answer;
    }
}


// [다른풀이1 - List 메서드]
/*
    if (i % 2 == 0)
    {
        list.RemoveRange(index + 1, list.Count  - (index + 1) );
    }
    else
    {
        list.RemoveRange(0, index);
    }
*/

// [다른풀이1 - LinQ] <- 최종 인덱스 계산 후 한 번에 LinQ
/*
    int start = 0;
    int end = arr.Length - 1;
    
    for(int i = 0; i < query.Length; ++i)
    {
        if(i % 2 == 0)
            end = start + query[i] - 1;
        else
            start = start + query[i];
    }
    
    if(start > end) return new int[1]{ -1 };
    return arr.Skip(start).Take(end - start + 1).ToArray();
*/