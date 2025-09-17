
namespace Daily_Algorithm._2025_09.day0917;

// [문제 설명] 그림 확대
// https://school.programmers.co.kr/learn/courses/30/lessons/181836

using System.Text;

public class No03
{
    public string[] Print(string[] picture, int k) {
        // 매 문자의 바로 오른쪽에 k-1 개 복제
        // 매 문자열 바로 다음 요소에 k-1개 복제

        string[] answer = new string[picture.Length * k];

        StringBuilder sb = new StringBuilder();
        string currentRow = String.Empty;
        
        for (int arrIdx = 0; arrIdx < picture.Length; arrIdx++)
        {
            sb.Clear();
            currentRow = picture[arrIdx];
        
            for (int stringIdx = 0; stringIdx < currentRow.Length; stringIdx++)
            {
                for (int n = 0; n < k; n++)
                {
                    sb.Append(currentRow[stringIdx]);
                }
                
            }

            int answerIdx = k * arrIdx;
            
            for (int m = answerIdx; m < answerIdx + k; m++)
            {
                answer[m] = sb.ToString();
            }
        }
        
        return answer;
    }
}

// [다른풀이1 - 어이도 없는 Linq]
// return picture.SelectMany(x => Enumerable.Repeat(new string(x.SelectMany(y => Enumerable.Repeat(y, k)).ToArray()), k)).ToArray();