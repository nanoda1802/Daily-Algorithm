namespace Daily_Algorithm._2025_09.day0904;

// [문제 설명] 문자열 겹쳐쓰기
// https://school.programmers.co.kr/learn/courses/30/lessons/181943


public class No12
{
    public string Print(string my_string, string overwrite_string, int s) 
    {
        string[] ingredients = new string[2];
        ingredients[0] = my_string.Substring(0,s);
        ingredients[1] = my_string.Substring(s + overwrite_string.Length);
        
        return ingredients[0] + overwrite_string + ingredients[1];
        
        
        // [실패 - 1] 아마 같은 문자열이 여러번 있는 문자열이라 의도치 않은 위치에서 Replace한 듯 함
        // string str = my_string.Substring(s,overwrite_string.Length);
        // return  my_string.Replace(str, overwrite_string);
        
        // [다른 풀이] 메서드 체이닝
        // return my_string.Remove(s, overwrite_string.Length).Insert(s, overwrite_string);
    }
}