namespace Daily_Algorithm._2025_11.day1105;
// 기능개발
//https://school.programmers.co.kr/learn/courses/30/lessons/42586

public class No02
{  
    // 진도가 100%일 때 배포
    // 뒤에 있는 기능이 앞에 있는 기능보다 먼저 개발될 수 있고,
    // 이때 뒤에 있는 기능은 앞에 있는 기능이 배포될 때 함께 배포
    
    // 배포되어야 하는 순서대로 작업의 진도가 적힌 정수 배열 progresses (100미만 자연수)
    // 각 작업의 개발 속도가 적힌 정수 배열 speeds (100미만 자연수)
    // 각 배포마다 몇 개의 기능이 배포되는지를 return 
    
    // 배포는 하루에 한 번
    // 진도율이 95%인 작업의 개발 속도가 하루에 4%라면 배포는 2일 뒤
    
    public int[] solution(int[] progresses, int[] speeds)
    {
        List<int> answer = new List<int>();
        int len = progresses.Length;
        int last = 0;
        
        while (last < len)
        {
            for (int i = 0; i < len; i++) progresses[i] += speeds[i];

            int count = 0;
            for (int i = last; i < len; i++)
            {
                if (progresses[i] >= 100)
                {
                    count++;
                    last = i + 1;
                }
                else break;
            }
            if (count > 0) answer.Add(count);
        }
        
        return answer.ToArray();
    }
}

