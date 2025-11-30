namespace Daily_Algorithm._2025_11.day1130;
// 거리두기 확인하기
// https://school.programmers.co.kr/learn/courses/30/lessons/81302

// places[i,j][k] : i가 대기실 번호, j가 행, k가 열 (5x5 격자)

// <행 마다 반복>
// P 등장 위치 기록, 현재 P와 최근 P 거리 체크
// 현재 P와 이전 행 P 위치들과의 거리도 체크
//  거리 3 이상인 쌍들은 통과 continue
//  거리 1이면 미준수 break
//  거리 2면 "경로 체크"
//      X로 막히지 않은 경로가 있다면 미준수 break
//      잘 막혀있다면 통과 continue

// 1차 시도 : 6,7,8,9,14,15,21,22,31
// curTargetTables.Count == 0 이면 continue 해서, 같은 행 P들 간 비교가 안 되고 있었음
// 비교 후 curTargetTables에 Add를 했기 때문. 어차피 foreach에서 HasNext가 false일 테니 
// 의미 없는 조건식이라 제거

// 2차 시도 : 8,31
// 기존은 바로 위 행과만 비교를 해버려서 두 칸 위 P가 있을 경우 놓쳤다...
// 조금 찝찝하지만 그냥 이전에 등장한 모든 P와 비교하도록 수정
// 메서드 시작할 때 거리 체크해서 2가 아니면 다 바로 반환하니까 큰 차이는 없을 거라 생각...
// 심지어 P 최대치가 25기도 하고...
// 실제로 오히려 시간이 준 쪽이 이씀....

public class No01
{
    public int[] solution(string[,] places)
    {
        int[] answer = new int[places.GetLength(0)];
        
        for (int i = 0; i < places.GetLength(0); i++)
        {
            answer[i] = CheckPlace(places, i);
        }
        
        return answer;
    }

    private int CheckPlace(string[,] places, int curPlace)
    {
        List<Table> prevTables = new List<Table>(25);
        for (int j = 0; j < 5; j++)
        {
            for (int k = 0; k < 5; k++)
            {
                if (!places[curPlace, j][k].Equals('P')) continue;
                
                Table curTable = new Table(j, k);
                foreach (Table otherTable in prevTables)
                {
                    if (!curTable.HasKeepDistanceWith(otherTable, places, curPlace)) return 0;
                }
                prevTables.Add(curTable);
            }
        }
        return 1;
    }

    private class Table
    {
        private int row;
        private int col;

        public Table(int row, int col)
        {
            this.row = row;
            this.col = col;
        }

        private int CalculateDistance(int otherRow, int otherCol)
        {
            return GetAbs(row - otherRow) + GetAbs(col - otherCol);
        }

        private bool IsSameRow(int otherRow)
        {
            return row == otherRow;
        }

        private bool IsSameColumn(int otherCol)
        {
            return col == otherCol;
        }

        public bool HasKeepDistanceWith(Table other, string[,] places, int curPlace)
        {
            int dist = CalculateDistance(other.row, other.col);
            if (dist >= 3) return true;
            if (dist <= 1) return false;
            
            if (IsSameRow(other.row)) 
                return places[curPlace, row][(col + other.col) / 2].Equals('X');
            if (IsSameColumn(other.col)) 
                return places[curPlace, (row + other.row) / 2][col].Equals('X');

            return places[curPlace, row][other.col].Equals('X') && places[curPlace, other.row][col].Equals('X');
        }

        private int GetAbs(int n)
        {
            return n < 0 ? -n : n;
        }
    }

}


