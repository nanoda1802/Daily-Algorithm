namespace Daily_Algorithm._2025_10.day1025;

// 최솟값 만들기
// https://school.programmers.co.kr/learn/courses/30/lessons/12941

// 두 자연수 배열 A B에서 한개씩 뽑아 곱함 (뽑은 인덱스의 숫자는 다시 뽑지 않음)
// 배열 길이만큼 반복하고, 곱한 값의 누적합 구하는데, "최소"인 경우로

public class No03 
{  
    public int solution(int[] A, int[] B) {
        // 한쪽에서 최소를, 반대에서 최대를 뽑아야함?
        // 한쪽은 오름차순, 반대는 내림차순 정렬하고 같은 인덱스 곱?
        // 맞네 굳
        
        int answer = 0;
        
        Array.Sort(A);
        Array.Sort(B,(e1,e2)=>e2-e1);

        for (int i = 0; i < A.Length; i++) answer += A[i] * B[i];
        
        return answer;
    }
}