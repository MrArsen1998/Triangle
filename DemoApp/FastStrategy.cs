using DemoApp;

class FastStrategy : IAsyncRidingStrategy
{
    private int _meters;

    public bool Riding { get; set; }

    public async Task Ride()
    {
        Console.WriteLine();

        Riding = true;

        while (Riding)
        {
            Console.Write($" Fast: {++_meters}");

            await Task.Delay(200);
        }

        Console.WriteLine();
    }
    public void StopRiding() => Riding = false;
}