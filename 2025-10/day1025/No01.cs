namespace Daily_Algorithm._2025_10.day1025;

// 최댓값과 최솟값
// https://school.programmers.co.kr/learn/courses/30/lessons/12939

// 공백으로 구분된 숫자 문자열
// "최소값 최대값" 반환


public class No01 
{  
    public string solution(string s) {
        int[] nums = s.Split(' ').Select(int.Parse).ToArray(); // [메모] java의 :: 처럼 활용가능한가부다
        return nums.Min() + " " + nums.Max();
    }
}