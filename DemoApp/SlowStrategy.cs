namespace DemoApp;

public class SlowStrategy : IAsyncRidingStrategy
{
    private int _meters;

    public bool Riding { get; set; }
    public async Task Ride()
    {
        Riding = true;

        while (Riding)
        {
            Console.Write($" Slow: {++_meters}");

            await Task.Delay(1000);
        }

        Console.WriteLine();
    }

    public void StopRiding() => Riding = false;
}