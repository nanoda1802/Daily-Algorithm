namespace Daily_Algorithm._2025_09.day0906;

// [문제 설명] 코드 처리하기
// https://school.programmers.co.kr/learn/courses/30/lessons/181932

public class No01
{
    public string Print(string code)
    {
        string answer = "";
        bool isOnMode = true;
        
        for (int i = 0; i < code.Length; i++)
        {
            if (code[i] == '1')
            {
                isOnMode = !isOnMode;
                continue;
            }

            if (isOnMode != isEven(i)) continue;
            
                answer += code[i];
        }
        
        return string.IsNullOrEmpty(answer) ?  "EMPTY" : answer;
    }

    private bool isEven(int idx)
    {
        return idx % 2 == 0;
    }
}

// [다른풀이1 - StringBuilder]
// Append()로 빌더에 모으다가 ToString()으로 반환
