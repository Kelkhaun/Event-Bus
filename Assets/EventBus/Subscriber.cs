public class Subscriber<TSubscriber> where TSubscriber : class
{
    public TSubscriber T { get; private set; }
    public int Priority { get; private set; }

    public Subscriber(TSubscriber subscriber, int priority)
    {
        T = subscriber;
        Priority = priority;
    }
}