namespace Daily_Algorithm._2025_10.day1003;

// [문제 설명] 연속된 수의 합
// https://school.programmers.co.kr/learn/courses/30/lessons/120923

public class No03
{
    public int[] solution(int num, int total) {
        // 연속된 정수의 합 공식 : (처음수 + 마지막수) * (수의개수) / 2
        
        int[] answer = new int[num];

        int first = -num;
        int last;

        for (int i = first; i < total; i++)
        {
            last = i + num - 1;
            
            if (total == (i + last) * num / 2)
            {
                first = i;
                break;
            }
        }
        
        for (int i = 0; i < num; i++)
        {
            answer[i] = first++;
        }
        
        return answer;
    }
}

// [메모] 다 풀고 깨달은 점 -> 첫 항을 구하는 거니까 공식을 뒤집어야 한다
// 1. total = (first + last) * num / 2 이고 last = first + num -1 니까
//    first = total/num - (num-1)/2 임디ㅏ...
// 2. float는 오류 발생할 수 있으니 양변에 2*num을 곱해
//    2*num*first = 2*total - (num-1) * num
// 3. 그리고 다시 양변에 나눠
//    " first = (2 * total - (num-1) * num) / (2 * num) "
// 4. 아래는 고친 풀이
/*
    int[] answer = new int[num];
    int first = (2 * total - (num-1) * num) / (2 * num);
           
    for (int i = 0; i < num; i++)
    {
        answer[i] = first++;
    }
            
    return answer;
*/

// [다른풀이1 - 이게 왜 되는 거징] -> 질답 참고!
/*
int sum = Enumerable.Range(1, num).Sum();
int offset = (total - sum) / num;

return Enumerable.Range(1+offset, num).ToArray(); 
*/