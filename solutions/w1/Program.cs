public class Program
{
    static void Main(string[] args)
    {
        Counter counter = new Counter();
        
        counter.CountTo(10);
        
        int finalCount = counter.GetCount();
        Console.WriteLine($"Final Count: {finalCount}");
    }
}

public class Counter
{
    private int _count = 0;

    public void CountTo(int target)
    {
        for (int i = 0; i < target; i++)
        {
            _count++;
            Console.WriteLine(_count);
        }
    }

    public int GetCount()
    {
        return _count;
    }
}