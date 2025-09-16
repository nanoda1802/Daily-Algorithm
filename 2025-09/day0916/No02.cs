
namespace Daily_Algorithm._2025_09.day0916;

// [문제 설명] 두수의 합
// https://school.programmers.co.kr/learn/courses/30/lessons/181846

using System.Text;

public class No02
{
    public string Print(string a, string b)
    {
        // [1] 두 숫자 문자열 길이 맞추기
        int len = a.Length > b.Length ? a.Length : b.Length;
        a = a.PadLeft(len, '0');
        b = b.PadLeft(len, '0');
        
        // [2] 스트링 빌더 준비
        StringBuilder sb = new StringBuilder();
        sb.Append(0);
        
        // [3] 올림수 위한 변수 준비
        int up = 0;

        // [4] 각 자리 더해 빌더에 넣기
        for (int i = len-1; i >= 0; i--)
        {
            // [Loop 1] 총합 = 각 자리 합 + 올림수
            int sum = (a[i] - '0') + (b[i] - '0') + up;
            
            // [Loop 2] 총합이 10보다 클 때, 십의자리 수 올림수에 할당 (작으면 up은 알아서 0이 됨)
            up = sum / 10;
            
            // [Loop-3] 빌더에 총합의 일의자리 수 넣기
            sb.Insert(0, sum % 10);
        }

        // [5] 마지막 순회 후 올림수 남았으면 맨 앞에 반영
        if (up > 0) sb.Insert(0, up);
        
        // [6] 미리 넣어둔 초기 0 제거
        sb.Remove(sb.Length-1, 1);
        
        // [7] 결과 반환
        return sb.ToString();
    }
}
