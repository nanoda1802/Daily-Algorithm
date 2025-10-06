namespace Daily_Algorithm._2025_10.day1006;

// [문제 설명] 콜라츠 추측
// https://school.programmers.co.kr/learn/courses/30/lessons/12943

public class No03
{
    public int solution(int num) {
        return num==1? 0 : (int)Collatz(num);
    }

    // 도중에 int를 초과하는 경우가 생긴댜...
    private long Collatz(long num, long cnt = 0)
    {
        num = num % 2 == 0 ? num / 2 : num * 3 + 1;
        cnt += 1;

        if (cnt >= 500) return -1;
        
        return num == 1 ? cnt : Collatz(num, cnt);
    }
}

// [다른풀이1 - 그냥 제일 좋았을 방법] -> 반복횟수가 500으로 제한돼있었으니...
/*
    long lNum = num;
    for (int i = 0; i < 500; i++)
    {
        if (lNum == 1) return i;
        lNum = lNum % 2 == 0 ? lNum / 2 : lNum * 3 + 1;                        
    }
    return -1; 
*/