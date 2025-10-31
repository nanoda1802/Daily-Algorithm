namespace Daily_Algorithm;

public static class Sort
{
    private static void Swap(int[] arr, int i1, int i2)  
    {  
        (arr[i1], arr[i2]) = (arr[i2], arr[i1]);
    }
    
    /* 평균 시간복잡도 N^2 */
    public static void BubbleSort(int[] arr)  
    {  
        int len = arr.Length;  
        for (int i = 0; i < len; i++)  
        {        
            for (int j = 0; j < len-i-1; j++)  
            {            
                if (arr[j] > arr[j+1]) Swap(arr,j,j+1);  
            }    
        }
    }  
    
    public static void SelectionSort(int[] arr)  
    {  
        int len = arr.Length;    
        for (int i = 0; i < len; i++)  
        {        
            int minIndex = i;  
            for (int j = i; j < len; j++)  
            {            
                if (arr[j] < arr[minIndex]) minIndex = j;        
            }        
            Swap(arr, i, minIndex);  
        }
    }
    
    public static void InsertionSort(int[] arr)  
    {  
        for (int i = 1; i < arr.Length; i++)
        {
            for (int j = i; j > 0; j--)
            {
                if (arr[j-1] > arr[j]) Swap(arr,j-1,j);
                else break;
            }
        }
    }
}