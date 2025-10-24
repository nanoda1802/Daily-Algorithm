namespace Daily_Algorithm._2025_10.day1024;

// [문제설명] 동영상 재생기  
// https://school.programmers.co.kr/learn/courses/30/lessons/340213  

// video_len 동영상의 길이를 나타내는 문자열   
// pos 기능이 수행되기 직전의 재생위치를 나타내는 문자열  
// op_start 오프닝 시작 시각을 나타내는 문자열   
// op_end 오프닝이 끝나는 시각을 나타내는 문자열   
// commands 사용자의 입력을 나타내는 1차원 문자열 배열   
      
// video_len, pos, op_start, op_end는 "mm:ss" 형식으로 mm분 ss초  
// commands의 원소는 "prev" 혹은 "next" (10초씩 앞뒤로 이동)  
// 현재 위치가 10초 미만인 경우 영상의 처음 위치로 이동합니다. 영상의 처음 위치는 0분 0초입니다.  
// 남은 시간이 10초 미만일 경우 영상의 마지막 위치로 이동합니다. 영상의 마지막 위치는 동영상의 길이와 같습니다.  
// 현재 재생 위치가 오프닝 구간(op_start ≤ 현재 재생 위치 ≤ op_end)인 경우 자동으로 오프닝이 끝나는 위치로 이동  
// [return] 사용자의 입력이 모두 끝난 후 동영상의 위치를 "mm:ss" 형식으로 반환   

public class No02
{  
    public string solution(string video_len, string pos, string op_start, string op_end, string[] commands) {  
		int curM = Convert.ToInt32(pos.Substring(0, 2));  
    	int curS = Convert.ToInt32(pos.Substring(3, 2));  
    	int lenM = Convert.ToInt32(video_len.Substring(0, 2));  
    	int lenS = Convert.ToInt32(video_len.Substring(3, 2));  
    	int opStartM = Convert.ToInt32(op_start.Substring(0, 2));  
    	int opStartS = Convert.ToInt32(op_start.Substring(3, 2));  
    	int opEndM = Convert.ToInt32(op_end.Substring(0, 2));  
    	int opEndS = Convert.ToInt32(op_end.Substring(3, 2));  
    	
	    if (CompareTime(curM,curS,opStartM,opStartS) >= 0 && CompareTime(curM,curS,opEndM,opEndS) <= 0)  
    	{        
		    curM = opEndM;        
		    curS = opEndS;    
		}    
		
	    // command 순회  
    	for (int i = 0; i < commands.Length; i++)  
    	{        
		    // [1] command 수행  
    	    OperateTime(ref curM, ref curS, commands[i]);  
    	    // [2] 00:00 ~ video_len 벗어나지 않도록 조정  
    	    if (CompareTime(curM, curS, 0, 0) < 0)  
    	    {            
		        curM = curS = 0;  
    	    }
    	    else if (CompareTime(curM, curS, lenM, lenS) > 0)  
    	    {            
		        curM = lenM;            
			    curS = lenS;        
			}  
    	    // [3] pos가 오프닝 구간이면 pos를 op_end로  
    	    if (CompareTime(curM,curS,opStartM,opStartS) >= 0 && CompareTime(curM,curS,opEndM,opEndS) <= 0)  
    	    {            
		        curM = opEndM;            
		        curS = opEndS;        
		    }    
		}  
	    
    	string m = "" + curM;  
    	string s = "" + curS;  
    	return m.PadLeft(2,'0') + ":" + s.PadLeft(2,'0');  
	}  
  
	// "mm:ss" 연산법...  
	// [1] substring 앞뒤해서 각각 m과 s에 할당  
	// [2] s먼저 계산 -> 올림 또는 내림 발생하는지 확인  
	// [3] m에 올림 또는 내림 적용  
	private void OperateTime(ref int curM, ref int curS, string dir)  
	{  
	    if (dir.Equals("next")) curS += 10;  
	    else if (dir.Equals("prev")) curS -= 10;  
	  
	    if (curS >= 60)  
	    {        
		    curS -= 60;  
	        curM += 1;  
	    }
	    else if (curS < 0)  
	    {        
		    curS += 60;  
	        curM -= 1;  
	    }
	}  
	  
	// "mm:ss" 비교법...  
	// [1] mm 일치 비교, 같으면 3번으로  
	// [2] mm이 큰 쪽이 나중  
	// [3] ss 비교  
	private int CompareTime(int m1, int s1, int m2, int s2)  
	{  
	    if (m1 != m2) return m1 - m2;  
	    return s1 - s2;  
	}  
}

// [메모] Convert.ToInt16은 결국 int.Parse를 호출함 -> 웬만하면 그냥 바로 parse하자
// [다른풀이] 초 단위로 통일하기 다음엔 꼭 기억하기...  
/*
private int TimeToSeconds(string time)  
{  
	var parts = time.Split(':');  
	int minutes = int.Parse(parts[0]);  
	int seconds = int.Parse(parts[1]);  
	return minutes * 60 + seconds;  
}  
  
private string SecondsToTime(int totalSeconds)  
{  
	int minutes = totalSeconds / 60;  
	int seconds = totalSeconds % 60;  
	return $"{minutes:D2}:{seconds:D2}";  
}
*/