namespace Daily_Algorithm._2025_11.day1114;
// 다리를 지나는 트럭
// https://school.programmers.co.kr/learn/courses/30/lessons/42583

// bridge_length 
// 칸의 개수 -> 다리가 10 칸이면 최대 10대 트럭이 오를 수 있고,
// 다리를 건너려면 10칸 이동해야하는 느낌
// 1초에 1칸씩 이동
// 이해가 어렵게 써놔써...

public class No02
{
    public int solution(int bridge_length, int weight, int[] truck_weights) {
        // 매초 해야할 일
        // 1. 다리에 있는 기존 트럭 한 칸 앞으로 보냄
        // 2. 이동한 트럭이 다리를 지났으면 다리 상태 최신화
        // 3. 현재 다리 상태 확인 후 새 트럭 올릴 수 있으면 올림
        
        int len = truck_weights.Length;
        int[] truckPos = new int[len]; // 트럭당 위치 (칸수, 대기면 0 도착이면 bridge_length + 1)
        int headTruck = 0, rearTruck = -1; // 다리 위 첫 트럭과 막 트럭의 인덱스
        int weightSum = 0; // 현재 다리 위 트럭 무게의 총합

        int second = 0;
        while (truckPos[len-1] <= bridge_length)
        {
            for (int i = headTruck; i <= rearTruck; i++) truckPos[i] += 1; // 다리 위 트럭들 한 칸 전진
            
            if (truckPos[headTruck] > bridge_length) // 선두 건넜으면 다리 상태 최신화
            {
                weightSum -= truck_weights[headTruck];
                headTruck += 1;
            }

            if (rearTruck < len-1 && weight >= weightSum + truck_weights[rearTruck+1]) // 무게 괜찮으면 트럭 추가
            {
                rearTruck += 1;
                weightSum += truck_weights[rearTruck];
                truckPos[rearTruck] += 1;
            }
            
            second++;
        }
        
        return second;
    }
}

