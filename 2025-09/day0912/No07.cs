namespace Daily_Algorithm._2025_09.day0912;

// [문제 설명] 문자열이 몇 번 등장하는지 세기
// https://school.programmers.co.kr/learn/courses/30/lessons/181871

public class No07
{
    public int Print(string myString, string pat)
    {
        int answer = 0;
        int patLen = pat.Length;
        int endIdx = 0;
        
        for (int i = 0; i < myString.Length-patLen+1; i++)
        {
            endIdx = i + patLen;
            if (myString[i..endIdx].Equals(pat)) answer+=1;
        }

        return answer;
    }
}

// [실제 제출 버전] <- Range가 안 되는 버전이더라구...
// if (myString.Substring(i, patLen).Equals(pat)) answer+=1;   
