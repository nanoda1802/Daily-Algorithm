namespace Daily_Algorithm._2025_10.day1017;

// [문제 설명] 옹알이 2
// https://school.programmers.co.kr/learn/courses/30/lessons/133499

public class No02
{
    public int solution(string[] babbling)
    {
        int answer = 0;

        string[] words = { "aya", "ye", "woo", "ma" };
        string[] sequences = { "ayaaya", "yeye", "woowoo", "mama" };

        foreach (string bab in babbling)
        {
            string temp = bab;
            
            for (int i = 0; i < words.Length; i++)
            {
                if (bab.Contains(sequences[i])) break;
                temp = temp.Replace(words[i], " ");
            }

            if (string.IsNullOrWhiteSpace(temp)) answer++;
        }
        
        return answer;
    }
}

// [메모] 대체 후 새로운 문자열에서 word에 맞는 문자열이 생기는 경우를 고려해야함
// 예를 들어, "mwooa" 는 중간의 woo를 추출하면 m과 a가 만나버림
// 순차적으로 동작하는 반복문 특성상 ma가 남아있으니 조건에 부합하다 판정하게 됨...