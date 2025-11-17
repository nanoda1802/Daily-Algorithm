namespace Daily_Algorithm._2025_11.day1117;
// 마법의 엘리베이터
// https://school.programmers.co.kr/learn/courses/30/lessons/148653

// 0층이 최하층, 0층보다 낮은 이동 입력은 무시  
// storey 층에서 0층으로 가기 위한 최소 마법의돌 개수  
// 버튼은 절대값이 10^c인 숫자들 ( 1, -1, 10, -10, 100, -100, ...)  
// 1의 자리부터 확인  
// 5이상이면 올리고, 미만이면 내리기  
// 맨 앞자리만 남기고 쭉 내려가면 끝 
public class No01
{
    public int solution(int storey) {  
        // 1의 자리에서부터 각 자리 순회 시작  
        // 반올림하고 반올림에 필요한 수 절대값 누적합에 기록  
        // 맨앞자리까지 반복 후 맨앞자리 수 누적합에 기록  
        int answer = 0;  
        bool isUp = false;  
        while (storey > 0)  
        {        
            int digit = storey % 10;  
            if (isUp) digit++;  
        
            int nextDigit = (storey % 100) / 10;  
            isUp = (digit > 5) || (digit == 5 && nextDigit >= 5);  
        
            answer += isUp ? 10-digit : digit;  
            storey /= 10;  
        }  
    
        if (isUp) answer++;  
        return answer;  
    }
}

// [메모] 핵심은 5일 때의 처리!
// 5점이나 먹어씀
