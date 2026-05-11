namespace TypicalProblems;

public class LinkedList<T>
    where T : struct
{
    public LinkedList()
    {        
    }

    public T Value { get; init; }

    public LinkedList(T value)
    {
        Value = value;
    }

    public LinkedList<T>? Next { get; set; }
}
