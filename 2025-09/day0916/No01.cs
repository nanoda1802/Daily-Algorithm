namespace Daily_Algorithm._2025_09.day0916;

// [문제 설명] 전국 대회 선발 고사
// https://school.programmers.co.kr/learn/courses/30/lessons/181851

public class No01
{
    public int Print(int[] rank, bool[] attendance)
    {
        int studentsCount = rank.Length;

        int startRank = 1;

        int a = FindStudent(ref startRank, studentsCount, rank, attendance);
        int b = FindStudent(ref startRank, studentsCount, rank, attendance);
        int c = FindStudent(ref startRank, studentsCount, rank, attendance);

        return 10000 * a + 100 * b + c;
    }

    private int FindStudent(ref int startRank, int studentsCount, int[] rank, bool[] attendance)
    {
        int num;
        
        for (int currentRank = startRank; currentRank <= studentsCount; currentRank++)
        {
            num = Array.IndexOf(rank, currentRank);
            
            if (attendance[num])
            {
                startRank = currentRank + 1;
                return num;
            }
        }

        return -1;
    }
}