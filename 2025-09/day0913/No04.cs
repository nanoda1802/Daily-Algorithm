namespace Daily_Algorithm._2025_09.day0913;

// [문제 설명] x 사이 개수
// https://school.programmers.co.kr/learn/courses/30/lessons/181867

public class No04
{
    public int[] Print(string myString)
    {
        int len = Array.FindAll(myString.ToCharArray(), c => c.Equals('x')).Length + 1;
        // 뭐한 거지... 그냥 split한 결과가 length인디...
        
        int[] answer = new int[len];

        string[] splitedString = myString.Split('x');

        for (int i = 0; i < splitedString.Length; i++)
        {
            answer[i] = splitedString[i].Length;
        }

        return answer;
    }
}