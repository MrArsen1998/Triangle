using DemoApp;

class Bicycle
{
    private IAsyncRidingStrategy _ridingStrategy;

    public Bicycle(IAsyncRidingStrategy ridingStrategy) => SetStrategy(ridingStrategy);

    public Task StartRiding() => _ridingStrategy.Ride();

    public void StopRiding() => _ridingStrategy.StopRiding();

    public void SetStrategy(IAsyncRidingStrategy ridingSrategy) => _ridingStrategy = ridingSrategy;
}