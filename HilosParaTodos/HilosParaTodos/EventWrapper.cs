namespace HilosParaTodos;
public class EventWrapper<T>
{
    private T value;
    public T Value
    {
        get => value;
        set => this.value = value;
    }

    public EventWrapper(T initialValue)
    {
        value = initialValue;
    }
}