namespace Daily_Algorithm._2025_10.day1006;

// [문제 설명] 핸드폰 번호 가리기
// https://school.programmers.co.kr/learn/courses/30/lessons/12948

public class No04
{
    public string solution(string phone_number) {
        return phone_number.Substring(phone_number.Length-4,4).PadLeft(phone_number.Length, '*'); 
    }
}
