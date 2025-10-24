namespace Daily_Algorithm._2025_10.day1024;

// [문제설명] 택배 상자 꺼내기  
// https://school.programmers.co.kr/learn/courses/30/lessons/389478

// 한 층에 w개씩 쌓아서 n개를 다 쌓기  
// n=22, w=6일 때 예시  
/*
 *       22 21 20 19
 * 13 14 15 16 17 18
 * 12 11 10 9  8  7
 * 1  2  3  4  5  6
 */    
// 택배 상자 A를 꺼내려면 먼저 A 위에 있는 다른 모든 상자를 꺼내야 A를 꺼낼 수 있습니다.  
// 예를 들어, 위 그림에서 8번 상자를 꺼내려면 먼저 20번, 17번 상자를 꺼내야 합니다.  
// 꺼내려는 상자 번호(=num)가 주어졌을 때, // 꺼내려는 상자를 포함해 총 몇 개의 택배 상자를 꺼내야 하는지 알고 싶습니다.  

public class No03 
{  
    public int solution(int n, int w, int num) {  
        // 1층+2층 -> 2w+1    
        // 2층+3층 -> 4w+1    
        // 3층+4층 -> 6w+1        
        // num박스 + num위박스 = 2 * num의층 * w + 1
        
        // [메모] 실제 수식과 프로그램 작동 방식은 다르디
        // int형일 때 소수부가 버려지는 걸 이용해 층수를 구했으니까
        // 현재층과 윗층번호 두 수식을 합치면 결과가 당연히 달라진당
    
        // 현재층 = (num + w - 1) / w    
        // 윗층번호 = 2 * w * 현재층 - a + 1    
        int cnt = 0;  
        while (num <= n)  
        {        
            int floor = (num + w - 1) / w;  
            num = 2 * w * floor - num + 1;  
            cnt++;    
        }  
        return cnt;  
    }
}