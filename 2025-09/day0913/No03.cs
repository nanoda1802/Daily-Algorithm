namespace Daily_Algorithm._2025_09.day0913;

// [문제 설명] 공백으로 구분하기 2
// https://school.programmers.co.kr/learn/courses/30/lessons/181868

public class No03
{
    public string[] Print(string my_string)
    {
        List<string> strList = new List<string>(my_string.Length);

        string[] strArr = my_string.Trim().Split(' ');
        
        for (int i = 0; i < strArr.Length; i++)
        {
            string s = strArr[i];
            if (!s.Equals("")) strList.Add(s);
        }
        
        return strList.ToArray();
    }
}

// [다른풀이1 - StringSplitOption 클래스]
// return my_string.Split(' ', StringSplitOptions.RemoveEmptyEntries);

// [다른풀이2 - IsNullOfWhiteSpace()]
// return my_string.Split().Where(w => !string.IsNullOrWhiteSpace(w)).ToArray();