namespace Daily_Algorithm._2025_09.day0907;

// [문제 설명] 주사위 게임 3
// https://school.programmers.co.kr/learn/courses/30/lessons/181916

using System.Linq;
using System.Collections.Generic;

public class No07
{
    public int Print(int a, int b, int c, int d) {
        // 1 네 개 모두 p로 같다면 -> 1111 * p 
        // 2 세 개 p, 하나 q면 -> (10 * p + q)의 제곱 
        // 2 두 개씩 p, q로 같으면 -> (p+q)*(p-q)의 절대값
        // 3 두 개 p, 하나 q, 하나 r이면 -> q * r 
        // 4 다 다르면 -> 최소값

        int answer = 0;
        
        Dictionary<int, int> dic = new Dictionary<int, int>();

        int[] ns = { a, b, c, d };

        foreach (int i in ns)
        {
            if (!dic.TryAdd(i, 1)) dic[i]++;
        }

        switch (dic.Count)
        {
            case 1: answer = 1111 * a; break;
            case 2:
                int p = 0;
                int q = 0;

                if (dic.ContainsValue(2))
                {
                    p = dic.Keys.Max();
                    q = dic.Keys.Min();

                    answer = (p + q) * (p - q);
                    break;
                }

                foreach (KeyValuePair<int,int> pair in dic)
                {
                    if (pair.Value == 3) p = pair.Key;
                    if (pair.Value == 1) q = pair.Key;
                }

                answer = (10 * p + q) * (10 * p + q);

                break;

            case 3:
                int Q = dic.Where(pair => pair.Value == 1).First().Key;
                int R = dic.Where(pair => pair.Value == 1).Last().Key;
                answer = Q * R; 
                break;
            case 4: answer = dic.Keys.Min(); break;
        }
        
        return answer;
    }
}

// [다른풀이1]
// abcd는 주사위 숫자니까 1~6 이내 -> 배열 하나 만들어서 1~6 인덱스에 해당하는 요소에 출현 횟수 카운트
/*
    int[] counts = new int[7]; // 각 숫자가 몇 번 나왔는지 카운트하는 배열 abcd는 기본으로 하나씩 추가
    counts[a]++;
    counts[b]++;
    counts[c]++;
    counts[d]++;
    
    int maxCount = 0;
    int minCount = 0;
    int maxValue = 0;
    
    // 1. 네 주사위에서 나온 숫자가 모두 같은 경우
    for (int i = 1; i <= 6; i++) {
        if (counts[i] == 4) {
            return i * 1111;
        }
    }
    
    // 2. 세 주사위에서 나온 숫자가 같고 나머지 하나는 다른 경우
    for (int i = 1; i <= 6; i++) {
        if (counts[i] == 3) {
            maxCount = i;
            break;
        }
    }
    if(maxCount > 0){
        for (int i = 1; i <= 6; i++) {
            if (counts[i] == 1) {
                minCount = i;
                break;
            }
        }
    
        return (int)Math.Pow(10 * maxCount + minCount, 2);
    }
    
    
    
    // 3. 두 개의 주사위 쌍이 같은 경우
    for (int i = 1; i <= 6; i++) {
        if (counts[i] == 2) {
            if(minCount != 0 && maxCount == 0 ) maxCount = i;
            if(minCount == 0) minCount = i;
        }
    }
    if(minCount > 0 && maxCount > 0 ) {
        return (minCount + maxCount) * Math.Abs(maxCount - minCount);
    }
    if(minCount > 0 && maxCount == 0){
        int mul = 1;
        for (int i = 1; i <= 6; i++) {
            if (counts[i] == 1) {
                mul*= i;
            }
        }
        return mul;
    }
    
    // 4. 네 주사위가 모두 다른 경우
    int minVal = 7;
    for (int i = 1; i <= 6; i++) {
        if (counts[i] == 1 && i < minVal) {
            minVal = i;
        }
    }
    
    return minVal;
*/