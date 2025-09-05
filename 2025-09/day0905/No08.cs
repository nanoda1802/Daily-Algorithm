namespace Daily_Algorithm._2025_09.day0905;

// [문제 설명] 조건 문자열
// https://school.programmers.co.kr/learn/courses/30/lessons/181934

public class No08
{
    public int Print(string ineq, string eq, int n, int m) {
        string oper = ineq + eq;

        switch (oper)
        {
            case ">=": return n >= m ? 1 : 0;
            case "<=": return n <= m ? 1 : 0;
            case ">!": return n > m ? 1 : 0;
            case "<!": return n < m ? 1 : 0;
        }
        
        return 0;
    }
}

// [다른풀이1 - Short Circuit] 
/*
    if(ineq == ">")
    {
        if(n < m) return 0;
    }
    else
    {
        if(n > m) return 0;
    }

    if(eq == "!")
    {
        if(n == m) return 0;
    }

    return 1;
*/