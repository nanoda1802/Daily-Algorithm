namespace Daily_Algorithm._2025_11.day1116;
// 연속된 부분 수열의 합
// https://school.programmers.co.kr/learn/courses/30/lessons/178870

// 뒤에서 부터 와요
// 현재 위치 i일 때, i 앞의 요소들은 전부 i 요소 보다 작거나 같음
// 즉, ( i요소 * (len-i-1) ) 가 k 보다 작으면 더 확인할 필요 없음

public class No01
{
    /* 성공! */
    public int[] solution(int[] sequence, int k) {
        // 투 포인터...?
        // start와 end 인덱스가 이씀 (둘다 lastIdx에서 시작)
        // 합을 기록할 sum이 있음 (k와 비교 예정)
        
        // 1. seq를 뒤에서 부터 순회
        // 2. sum에 start요소를 더하고 k와 비교
        // 2-A. k보다 작으면 start-1 하고 다시 2번으로
        // 2-B. k와 같으면? answer에 기록된 시작&끝과 비교 후 start-1 하고 다시 2번으로
        //      간격이 더 짧으면 answer 갱신
        // 2-C. k보다 크면 sum에서 end요소 빼고 end-1 하고 다시 2번으로
        // 3. end요소 * (end+1)이 k보다 작으면 그 앞은 불가능하므로 순회 종료

        // 이동했을 때만 더하거나 빼야해...
        
        int lastIdx = sequence.Length - 1;
        int[] answer = {0,lastIdx};
        int start = lastIdx;
        int end = lastIdx;    
        long sum = sequence[lastIdx];
        
        while (end >= 0 && k <= sequence[end] * (end+1))
        {
            Console.WriteLine($"{start}~{end} : {sum}");
            Console.WriteLine($"현재기록 : {answer[0]}~{answer[1]}");
            long diff = sum - k;
            if (start == 0 && diff < 0) break;
            
            if ((diff == 0) && (answer[1]-answer[0] >= end-start))
            {
                Console.WriteLine($"갱신! {start}&{end}");
                answer[0] = start;
                answer[1] = end;
            } 
            
            if (diff >= 0) sum -= sequence[end--];
            if (start > 0) sum += sequence[--start];
        }
        
        return answer;
    }
    
    /* 시간초과 실패 */
    public int[] failedSolution(int[] sequence, int k) {
        // 1. seq를 뒤에서 부터 순회 (현재 위치 i)
        // 2. i마다 연결된 앞 요소들을 더해가며 k가 되는 지 확인
        // 2-A. i요소 또는 요소들의 합이 k를 초과하면 i--
        // 2-B. k가 딱 된다면?
        // 2-B-A. 이미 찾은 시작&끝 과 비교해 더 짧거나 같으면 갱신
        // 2-B-B. 더 길면 i--
        // 3. ( i요소 * (len-i-1) ) < k 되면 순회 종료

        int maxIdx = sequence.Length - 1;
        int[] answer = { 0, maxIdx };

        for (int i = maxIdx; i >= 0; i--)
        {
            if (k > (sequence[i] * (i+1))) break;
            long sum = 0;
            for (int j = i; j >= 0; j--)
            {
                sum += sequence[j];
                if (sum > k) break;
                if (sum == k)
                {
                    int diff = (i - j) - (answer[1] - answer[0]);
                    if ((diff < 0) || (diff == 0 && answer[0] > j))
                    {
                        answer[0] = j;
                        answer[1] = i;
                    }
                    break;
                }
            }
        }
        
        return answer;
    }
}

