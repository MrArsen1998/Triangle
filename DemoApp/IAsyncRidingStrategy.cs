namespace DemoApp;

public interface IAsyncRidingStrategy
{
    bool Riding { get; set; }

    Task Ride();
    void StopRiding();
}