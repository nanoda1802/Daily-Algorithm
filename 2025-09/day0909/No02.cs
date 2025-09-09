namespace Daily_Algorithm._2025_09.day0909;

// [문제 설명] 글자 지우기
// https://school.programmers.co.kr/learn/courses/30/lessons/181900

public class No02
{
    public string Print(string my_string, int[] indices) {
        string answer = "";
        bool isIn = false;

        char[] myChars = my_string.ToCharArray();
        
        for (int i = 0; i < myChars.Length; i++)
        {
            isIn = false;
            
            foreach (int index in indices)
            {
                if (index == i)
                {
                    isIn = true;
                    break;
                }
            }

            if (isIn) myChars[i] = '!';
            answer += myChars[i];
        }
        
        return answer.Replace("!", "");
    }
}

// [다른풀이1 - Linq]
// return new string(my_string.Where((w, index) => !indices.Contains(index)).ToArray());