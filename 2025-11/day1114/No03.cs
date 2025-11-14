using System.Text;

namespace Daily_Algorithm._2025_11.day1114;
// 큰 수 만들기
// https://school.programmers.co.kr/learn/courses/30/lessons/42883

// 숫자 1924에서 수 두 개를 제거하면
// [19, 12, 14, 92, 94, 24] 를 만들 수 있습니다.
// 이 중 가장 큰 숫자는 @9@4 -> 94

public class No03
{
    public string solution(string number, int k) {
        // 탐욕법은 근시안적으로 당장의 최선을 좇는 방법
        // 핵심 -> 자릿수가 고정돼있으니 앞 숫자가 크면 아무튼 큼
        // 매번 뒤에 추가할 여유 숫자를 남겨놓고, 그 이전 중 젤 큰 놈을 앞자리로
        
        // 0 ~ k 번째 요소 중 최댓값을 찾기
        // 그 녀석 위치를 a라 할 때, 다시
        // a ~ k-1+1 번째 요소 중 최댓값을 찾기 (하나 넣었으니 더 찾아도 되니까 +1 추가)
        // 반복, a가 뒤를 추월할 때까지
        // 남은 숫자는 a+1번째부터 쭉 붙이기

        StringBuilder sb = new StringBuilder();
        int start = 0, end = k;
        while (start < end)
        {
            char max = char.MinValue;
            for (int i = start; i <= end; i++)
            {
                if (number[i] <= max) continue;
                max = number[i];
                start = i+1;
                if (number[i].Equals('9')) break; // [핵심] 9보다 큰 한자리 정수는 없으니 불필요한 순회 막기 (대략 6000ms -> 3ms) 
            }
            sb.Append(max);
            end = Math.Clamp(end + 1, 0, number.Length - 1);
        }

        if (sb.Length < number.Length-k) // [핵심] len=2이고, k=1 일때... 방지
        {
            for (int i = start; i < number.Length; i++) sb.Append(number[i]);
        }
        return sb.ToString();
    }
}

