namespace Daily_Algorithm._2025_09.day0922;

// [문제 설명] 모음 제거
// https://school.programmers.co.kr/learn/courses/30/lessons/120849

public class No05
{
    public string solution(string my_string) {
        char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

        foreach (char vowel in vowels)
        {
            my_string = my_string.Replace(vowel+"", "");
        }

        return my_string;
    }
}

// [다른풀이1 - 정규식]
// return Regex.Replace(my_string, @"a|e|i|o|u", "");