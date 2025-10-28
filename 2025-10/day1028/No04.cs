namespace Daily_Algorithm._2025_10.day1028;
// 할인행사
// https://school.programmers.co.kr/learn/courses/30/lessons/131127

// want 원하는 제품 이름들  
// number 원하는 제품들의 각 수량  
// discount 일일 할인 제품명  
  
// 할인하는 제품은 하루에 하나씩만 구매  
// 원하는 제품과 수량이 할인하는 날짜와 10일 연속으로 일치할 경우에 맞춰서 회원가입  
// 회원가입 가능할 날짜 수를 return (없으면 0)
public class No04
{
    public int solution(string[] want, int[] number, string[] discount) 
    {
        // i ~ i+9 요소를 확인
        // 다음 회차엔 i 요소를 빼고, i+10 요소를 추가
        // 그 다음 회차엔 i+1 요소를 빼고, i+11 요소를 추가
        
        int answer = 0;
        Dictionary<string, int> dic = new Dictionary<string, int>();
        for (int i = 0; i < want.Length; i++) dic.Add(want[i], number[i]);
        
        for (int i = 0; i < 10; i++)
        {
            Upsert(discount[i],dic,-1);
            if (Check(dic)) answer++;
        } 
        
        for (int i = 1; i <= discount.Length-10; i++)
        {
            Upsert(discount[i-1],dic,1);
            Upsert(discount[i+9],dic,-1);
            if (Check(dic)) answer++;
        }
        
        return answer;
    }

    private void Upsert(string key, Dictionary<string,int> dic, int val)
    {
        if (dic.ContainsKey(key)) dic[key] += val;
    }

    private bool Check(Dictionary<string, int> dic)
    {
        foreach (int cnt in dic.Values)
        {
            if (cnt > 0) return false;
        }
        return true;
    }
}

// [메모] 반복을 최소화하기 위해서 슬라이딩 윈도우 방식을 써보았다
// 날짜가 바뀌면 지난 날짜와 추가된 날짜의 정보만 갱신해주도록 했는디
// 생각보단 성능 차이가 크지 않은 건지 어쩐지 모르겠다...
// 아마 dic의 모든 key를 확인해서 그런 거 같은디,
// 각 key 값이 0보다 큰지 아닌지 역시 매핑해놓고, 갱신된 key 값만 확인하도록 했어야 했으려나 싶다...!
