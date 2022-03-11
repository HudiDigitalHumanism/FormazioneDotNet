namespace WebApplication1.DI;

public interface IScopedInterface
{
}

public interface ITransitentInterface
{
}

public interface ISingletonInterface
{
}


public class ConcretClass : IScopedInterface, ITransitentInterface, ISingletonInterface
{
    private readonly Guid state;
    public ConcretClass()
    {
        state = Guid.NewGuid();
    }

    public override string ToString()
    {
        return state.ToString();
    }
}

