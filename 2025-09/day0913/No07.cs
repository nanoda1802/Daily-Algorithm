using System.Text;

namespace Daily_Algorithm._2025_09.day0913;

// [문제 설명] 문자열 바꿔서 찾기
// https://school.programmers.co.kr/learn/courses/30/lessons/181864

public class No07
{
    public int Print(string myString, string pat) {
        // newString = myString의 'A' -> 'B', 'B' -> 'A'
        // newString 중 pat이 있으면 1 없으면 0

        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < myString.Length; i++)
        {
            char c = myString[i] switch
            {
                'A' => 'B',
                'B' => 'A',
                _ => myString[i]
            };

            sb.Append(c);
        }

        return sb.ToString().Contains(pat) ? 1 : 0;
    }
}

// [메모] 왜 신문법 하나도 못 알아먹는 겨

// [다른풀이1 - 씽크빅] -> 두번째 replace에서 덮어씌워지는 걸 방지하기 위해 소문자로 변환!!
/*
    myString = myString.Replace("A", "b").Replace("B", "a");
    return myString.Contains(pat.ToLower()) ? 1 : 0;
*/