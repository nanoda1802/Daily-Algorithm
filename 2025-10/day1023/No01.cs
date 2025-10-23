namespace Daily_Algorithm._2025_10.day1023;

// [문제 설명] 개인정보 수집 유효기간  
// https://school.programmers.co.kr/learn/courses/30/lessons/150370  
  
public class No01 
{  
    public int[] solution(string today, string[] terms, string[] privacies) 
    {  
        List<int> answer = new List<int>();
        
        Dictionary<char, int> termDic = new Dictionary<char, int>();
        foreach (string term in terms)
        {
            termDic.Add(term[0],Convert.ToInt16(term.Substring(2)));
        }

        for (int i = 0; i < privacies.Length; i++)
        {
            string p = privacies[i];
            int term = termDic[p[p.Length - 1]];

            int[] ymd =
            {
                Convert.ToInt16(p.Substring(0, 4)), 
                Convert.ToInt16(p.Substring(5, 2)), 
                Convert.ToInt16(p.Substring(8, 2))
            };
            
            ymd[1] += term;
            ymd[2] -= 1;
            if (ymd[1] > 12) // 의외의 핵심 부분...
            {
                ymd[0] += (ymd[1]-1) / 12;
                ymd[1] = (ymd[1]-1) % 12 + 1;
            }
            
            int[] todayYmd =
            {
                Convert.ToInt16(today.Substring(0, 4)), 
                Convert.ToInt16(today.Substring(5, 2)),
                Convert.ToInt16(today.Substring(8, 2))
            };

            for (int j = 0; j < ymd.Length; j++)
            {
                if (todayYmd[j] != ymd[j]) // 의외의 핵심 부분2...
                {
                    if (todayYmd[j] > ymd[j]) answer.Add(i+1);
                    break;
                }
            }
        }
        
        return answer.ToArray();  
    }
}

// [다른풀이1 - 일수 계산]
// 아예 00년 01월 01일 기준으로 일수를 계산해 비교한 사람이 있음
// 오히려 안전하고 편했을지도