namespace Daily_Algorithm._2025_11.day1113;
// 주차 요금 계산
// https://school.programmers.co.kr/learn/courses/30/lessons/92341

// fees [180, 5000, 10, 600]
// 기본시간, 기본요금, 단위시간, 단위요금
// 시간은 분 단위
// 누적시간 <= 기본시간 : 기본요금
// 누적시간 > 기본시간 : 기본요금 + 초과분 단위요금
// 누적시간 : 하루 총 이용 시간 

// records ["16:00 3961 IN","16:00 0202 IN","18:00 3961 OUT","18:00 0202 OUT","23:58 3961 IN"]
// "시각 차번 내역" 공백으로 구분
// 시각 기준 오름차순
// 입차는 했는데 출차가 없으면 23:59에 출차한 걸로 간주

// 차량 번호가 작은 자동차부터 청구할 주차 요금을 차례대로 정수 배열에 담아서 return

public class No01
{
    public int[] solution(int[] fees, string[] records) {
        // in이면 -time, out이면 +time 하면 누적시간 나옴
        // 마지막 out이 없으면 무조건 0이하정수? -> 23:59 더해주기

        SortedList<string, int> dic = new SortedList<string, int>();
        
        foreach (string record in records)
        {
            string[] ctx = record.Split(' ');
            dic.TryAdd(ctx[1], 0);
            int time = ToMinute(ctx[0]);
            dic[ctx[1]] += ctx[2].StartsWith('I') ? -time : time;
        }

        int[] answer = new int[dic.Count];
        int idx = 0;
        
        foreach (KeyValuePair<string, int> pair in dic) // 순회중 콜렉션 요소의 값을 수정하지 않도록 하자...ㅠ
        {
            int totalTime = pair.Value <= 0 ? pair.Value + ToMinute("23:59") : pair.Value;
            int extraTime = totalTime - fees[0];
            int fee = fees[1];
            if (extraTime > 0) fee += (extraTime + fees[2] - 1) / fees[2] * fees[3];
            answer[idx++] = fee;
        } 
        
        return answer;
    }

    private int ToMinute(string time)
    {
        string[] hm = time.Split(':');
        return (int.Parse(hm[0]) * 60) + int.Parse(hm[1]);
    }
}

