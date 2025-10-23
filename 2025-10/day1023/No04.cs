namespace Daily_Algorithm._2025_10.day1023;

// [문제설명] 유연근무제  
// https://school.programmers.co.kr/learn/courses/30/lessons/388351

// 오늘부터 일주일 동안 각자 설정한 출근 희망 시각에 늦지 않고 출근한 직원들에게 상품을 주는 이벤트를 진행  
// 출근 희망 시각 + 10분까지 (희망 시각이 9시 58분인 직원은 10시 8분까지 출근)  
// !! 토요일, 일요일의 출근 시각은 이벤트에 영향을 끼치지 않습니다 !!  
// 모든 시각은 시에 100을 곱하고 분을 더한 정수로 표현 (10시 13분은 1013, 9시 58분은 958)  
// 직원 n명이 설정한 출근 희망 시각을 담은 1차원 정수 배열 schedules
// 700 ≤ schedules[i] ≤ 1100  
// 직원들이 일주일 동안 출근한 시각을 담은 2차원 정수 배열 timelogs
// timelogs[i][j]는 i + 1번째 직원이 이벤트 j + 1일차에 출근한 시각  
// 이벤트를 시작한 요일을 의미하는 정수 startday
// 1은 월요일, 2는 화요일, 3은 수요일, 4는 목요일, 5는 금요일, 6은 토요일, 7은 일요일  
// 상품을 받을 직원의 수를 return  
// ?? 출근 희망 시각과 실제로 출근한 시각을 100으로 나눈 나머지는 59 이하 ??  

public class No04
{  
    public int solution(int[] schedules, int[,] timelogs, int startday) {  
        // 토/일은 스킵  
        // 오늘이 토/일인지 아는 방법?
    
        // hope + 10 -> limit  
        // 1010 + 10 -> 1020    
        // 1055 + 10 -> 1065 -> 1105        
        // hour = hope/100  
        // minute = hope%100        
        // minute에 10 더하기 -> 60 초과하면 차이만 남기고 올림 -> hour에 1 더하기  
        // 11시까지니까 오후 신경 X  
    
        int answer = 0;  
    
        for (int i = 0; i < timelogs.GetLength(0); i++)  
        {        
            int hope = schedules[i] + 10;  
            if (hope % 100 >= 60) hope += 40;  
            bool isPrize = true;  
        
            for (int j = 0; j < 7; j++)  
            {            
                int today = (j + startday - 1) % 7 + 1;  
                if(today >= 6) continue;  
            
                if (timelogs[i, j] > hope)  
                {                
                    isPrize = false;  
                    break;  
                }        
            }        
        
            if (isPrize) answer++;  
        }    
    
        return answer;  
    }  
}

// [메모] 40이 나오는 이유 (초과한 분수로 60을 빼고 올림수로 시간인 100을 더하니까!)  
/*
int hope = schedules[i] + 10;
if (hope % 100 >= 60)
{
    hope -= 60;hope += 100;
}
*/