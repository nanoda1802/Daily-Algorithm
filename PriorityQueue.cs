namespace Daily_Algorithm;

public class PriorityQueue1
{
    private int[] _heapTree;
    private readonly bool _isMinHeap;
    public int Count { get; private set; }

    public PriorityQueue1(int capacity, bool isMinHeap = false)
    {
        Count = 0;
        _isMinHeap = isMinHeap;
        _heapTree = new int[capacity];
    }

    public void Enqueue(int item)
    {
        if (Count == _heapTree.Length)
        {
            Array.Resize(ref _heapTree, Count * 2);
        }
        _heapTree[Count] = item;
        HeapifyUp(Count);
        Count++;
    }

    public int Dequeue()
    {
        int item = _heapTree[0];
        Count--;
        _heapTree[0] = _heapTree[Count];
        HeapifyDown(0);
        return item;
    }

    public bool TryDequeue(out int item)
    {
        if (Count == 0)
        { 
            item = 0;
            return false;
        }
        item = Dequeue();
        return true;
    }

    public int Peek()
    {
        return _heapTree[0];
    }

    public bool TryPeek(out int item)
    {
        if (Count == 0)
        { 
            item = 0;
            return false;
        }
        item = Peek();
        return true;
    }

    public void Clear()
    {
        Array.Clear(_heapTree, 0, _heapTree.Length);
        Count = 0;
    }

    private void HeapifyUp(int i)
    {
        while (i > 0)
        {
            int parent = IndexOfParent(i);
            if (!Compare(i, parent)) break;
            Swap(i, parent);
            i = parent;
        }
    }

    private void HeapifyDown(int i)
    {
        while (IndexOfLeftChild(i) < Count)
        {
            int child = IndexOfLeftChild(i);
            
            int rightChild = IndexOfRightChild(i);
            if (rightChild < Count)
                child = Compare(child,rightChild) ? child : rightChild;
            
            if (Compare(i,child)) break;
            Swap(i,child);
            i = child;
        }
    }
    
    private void Swap(int i, int j)
    {
        (_heapTree[i], _heapTree[j]) = (_heapTree[j], _heapTree[i]);
    }

    private bool Compare(int i, int j)
    {
        return _isMinHeap ? _heapTree[i] < _heapTree[j] : _heapTree[i] > _heapTree[j];
    }

    private int IndexOfParent(int i)
    {
        return (i - 1) / 2;
    }

    private int IndexOfLeftChild(int i)
    {
        return 2 * i + 1;
    }

    private int IndexOfRightChild(int i)
    {
        return 2 * i + 2;
    }

    public void Print()
    {
        for (int i = 0; i < Count; i++) Console.Write($"{_heapTree[i]}/");
        Console.WriteLine();
    }
}


// 만약 SortedSet으로 구현한다면 필요한 Comparer
public class PQComparer : IComparer<int>
{
    private readonly bool _isMinHeap;

    public PQComparer(bool isMinHeap)
    {
        _isMinHeap = isMinHeap;
    }

    public int Compare(int x, int y)
    {
        return _isMinHeap ? y - x : x - y;
    }
}