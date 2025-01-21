using HilosParaTodos;

var finalizarWrapper = new EventWrapper<Action>(() => { Console.WriteLine("Suscriptor A"); });
finalizarWrapper.Value += () => { Console.WriteLine("Suscriptor B"); };

MiHilo t1 = new MiHilo("x", finalizarWrapper);
MiHilo t2 = new MiHilo("y", finalizarWrapper);

finalizarWrapper.Value += () => { Console.WriteLine("Suscriptor C"); };

t1.Start();
t2.Start();

class Program 
{
    static void Main(string[] args)
    {
        var finalizarWrapper = new EventWrapper<Action>(() => { Console.WriteLine("Suscriptor A"); });
        finalizarWrapper.Value += () => { Console.WriteLine("Suscriptor B"); };

        MiHilo t1 = new MiHilo("x", finalizarWrapper);
        MiHilo t2 = new MiHilo("y", finalizarWrapper);

        finalizarWrapper.Value += () => { Console.WriteLine("Suscriptor C"); };

        t1.Start();
        t2.Start();
    }
}