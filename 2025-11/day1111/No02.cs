namespace Daily_Algorithm._2025_11.day1111;
// 택배상자
// https://school.programmers.co.kr/learn/courses/30/lessons/131704

// curBox 현재 메인 벨트의 상자 번호
// sub 서브 벨트

// [2, 1, 4, 3, 6, 5, 8, 7, 10, 9]
// [2, 1, 6, 7, 5, 8, 4, 9, 3, 10] 

// order[i]와 sub.Peek()을 비교
// <일치> 서브에서 빼고 (sub.Pop())
// 기사님께 드리기 (answer++)
// <불일치> 다음 비교로
        
// order[i]와 curBox를 비교
// <일치> 기사님께 드리기 (answer++)
// <불일치> 서브에 넣기 (sub.Push())

public class No02
{
    public int solution(int[] order) {
        int answer = 0;
        Stack<int> sub = new Stack<int>();
        int curBox = 1;
        
        foreach (int orderBox in order)
        {
            if (sub.TryPeek(out int subBox) && subBox == orderBox)
            {
                sub.Pop();
                answer++;
                continue;
            }

            bool isFound = false;
            
            while (curBox <= order.Length)
            {
                if (curBox == orderBox)
                {
                    isFound = true;
                    answer++;
                    curBox++;
                    break;
                }
                
                sub.Push(curBox++);
            }

            if (!isFound) break;
        }
        
        return answer;
    }
}

