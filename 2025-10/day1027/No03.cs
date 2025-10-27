namespace Daily_Algorithm._2025_10.day1027;

// 카펫
// https://school.programmers.co.kr/learn/courses/30/lessons/42842

// 중앙에는 노란색으로 칠해져 있고 테두리 1줄은 갈색  
// 갈색 격자의 수 brown, 노란색 격자의 수 yellow
// 카펫의 가로, 세로 크기를 순서대로 배열에 담아 return  
public class No03
{  
    public int[] solution(int brown, int yellow) {  
        int[] answer = new int[2];  
        // 2a + 2(b-2) = brown  
        // (a-2) * (b-2) = yellow  
          
        // ab - 2(a+b) + 4 = yellow  
        // ab -2((brown+4)/2) + 4 = yellow    
        // ab -brown - 4 +4 = yellow   
         
        // "a+b = (brown + 4) / 2"  
        // "ab = yellow + brown"    
  
        int sum = (brown + 4) / 2;  
        int mul = yellow + brown;  
  
        int dis = sum * sum - 4 * mul;  
        int sqrt = (int) Math.Sqrt(dis);  
        
        answer[0] = (sum + sqrt) / 2;  
        answer[1] = (sum - sqrt) / 2; 
     
        return answer;  
    }
}

// [메모] 근의 공식
// ax2 + bx + c = 0일때, 판별식 dis = root(b2 - 4ac)라 하면 x = (-b + -d) / 2
// 그럼 답은 { (d - b)) / 2, (-b - d)) / 2 }
// 가로의 길이가 같거나 크다고 했으니까 +d를 0번째 자리에 넣으면 되고...
// 길이가 음수 나올리 없는건 확정적이니까 따로 검사할 필요도 없습니다.

// [메모] 문제 의도는 완전탐색이었음..! 