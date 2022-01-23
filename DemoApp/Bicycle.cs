using DemoApp;

class Bicycle
{
    private readonly IAsyncRidingStrategy _ridingStrategy;

    public Bicycle(IAsyncRidingStrategy ridingStrategy)
    {
        ArgumentNullException.ThrowIfNull(ridingStrategy);

        _ridingStrategy = ridingStrategy;
    }

    public Task StartRiding() => _ridingStrategy.Ride();

    public void StopRiding() => _ridingStrategy.StopRiding();
}