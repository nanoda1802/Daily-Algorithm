namespace Daily_Algorithm._2025_09.day0924;

// [문제 설명] 모스부호1
// https://school.programmers.co.kr/learn/courses/30/lessons/120838

public class No06
{
    public string solution(string letter) {
        string answer = "";

        string[] arr = letter.Split(' ');

        for (int i = 0; i < arr.Length; i++)
        {
            switch (arr[i])
            {
                case ".-": answer += 'a'; break;
                case "-...":answer += 'b'; break;
                case "-.-.":answer += 'c'; break;
                case "-..":answer += 'd'; break;
                case ".":answer += 'e'; break;
                case "..-.":answer += 'f'; break;
                case "--.":answer += 'g'; break;
                case "....":answer += 'h'; break;
                case "..":answer += 'i'; break;
                case ".---":answer += 'j'; break;
                case "-.-":answer += 'k'; break;
                case ".-..":answer += 'l'; break;
                case "--":answer += 'm'; break;
                case "-.":answer += 'n'; break;
                case "---":answer += 'o'; break;
                case ".--.":answer += 'p'; break;
                case "--.-":answer += 'q'; break;
                case ".-.":answer += 'r'; break;
                case "...":answer += 's'; break;
                case "-":answer += 't'; break;
                case "..-":answer += 'u'; break;
                case "...-":answer += 'v'; break;
                case ".--":answer += 'w'; break;
                case "-..-":answer += 'x'; break;
                case "-.--":answer += 'y'; break;
                case "--..":answer += 'z'; break;
            }
        }
        
        return answer;
    }
}
