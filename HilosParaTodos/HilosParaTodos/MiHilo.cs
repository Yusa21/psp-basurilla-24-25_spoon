namespace HilosParaTodos;

public class MiHilo
{
    Thread hilo;
    private string text;
    private EventWrapper<Action> finalizarWrapper;
   
    public MiHilo(string text, EventWrapper<Action> finalizarWrapper)
    {
        this.text = text;
        this.finalizarWrapper = finalizarWrapper;
        this.finalizarWrapper.Value += () => { Console.WriteLine($"Hilo {text}"); };
        hilo = new Thread(_process);
    }

    public void Start()
    {
        hilo.Start();
    }

    void _process()
    {
        for (int i = 0; i < 1000; i++) Console.Write(text);
        finalizarWrapper.Value?.Invoke();
        Console.WriteLine($"Ha terminado: {text}");
    }
}
