namespace Daily_Algorithm._2025_10.day1002;

// [문제 설명] 로그인 성공?
// https://school.programmers.co.kr/learn/courses/30/lessons/120883

public class No04
{
    public string solution(string[] id_pw, string[,] db) {
        for (int i = 0; i < db.GetLength(0); i++)
        {
            if (id_pw[0].Equals(db[i, 0]))
            {
                return id_pw[1].Equals(db[i, 1]) ? "login" : "wrong pw";
            }
        }

        return "fail";
    }
}