namespace Daily_Algorithm._2025_11.day1127;
// 디펜스 로봇
// https://school.programmers.co.kr/learn/courses/30/lessons/142085

// 쭉 누적해 가다가 합이 n을 초과하게 되는 경우 누적된 요소의 최대 값을 뺌 (무적 사용)  
// 그래도 모자르면 안 모자를 때까지 반복  
  
// 매 라운드 Loop
// 1. 적을 막아본다. n - enemy[i]  
//      적을 pq에 기록한다. 
// 1-A. 성공했으면 다음 라운드로 간다. n >= 0  
// 1-B. 실패했으면 무적권을 시도한다.  
// 2. k > 0 인 동안 pq에서 무적권을 시도한다.  
// 2-1. n += pq.Dequeue();  
// 2-1-A. 무적권으로 통과가 되면 통과한다. n >= 0  
// 2-1-B. 통과되지 않으면 재시도한다.   

// 시간은 엄청 오래 걸리긴 하는데, 일단 통과가 됐어...

public class No01
{
    public class Solution {  
        public int solution(int n, int k, int[] enemy) {  
            PriorityQueue pq = new PriorityQueue();  
            for (int i = 0; i < enemy.Length; i++)  
            {            
                n -= enemy[i];            
                pq.Enqueue(new Round(i,enemy[i]));  
                if (n >= 0) continue;  
  
                bool isOver = true;  
                while (k > 0)  
                {                
                    k -= 1;  
                    n += pq.Dequeue();  
                    if (n < 0) continue;  
                    isOver = false; break;  
                }  
                if (isOver) return i;  
            }        
            return enemy.Length;  
        }  
    
        private class Round : IComparable<Round>  
        {        
            private int num;  
            private int enemyCount;  
  
            public Round(int num, int count)  
            {            
                this.num = num;  
                enemyCount = count;  
            }  
            public int GetEnemyCount()  
            {            
                return enemyCount;  
            }  
            public int CompareTo(Round other)  
            {            
                int c = other.enemyCount.CompareTo(this.enemyCount);  
                return c != 0 ? c : num.CompareTo(other.num);  
            }    
        } 
             
        private class PriorityQueue  
        {  
            SortedSet<Round> _heap = new SortedSet<Round>();  
            public void Enqueue(Round value)   
            {  
                _heap.Add(value);  
            }  
            public int Dequeue()  
            {            
                if (_heap.Count == 0) return -1;  
                Round v = _heap.First();  
                _heap.Remove(v);  
                return v.GetEnemyCount();  
            }    
        }
    }
}

