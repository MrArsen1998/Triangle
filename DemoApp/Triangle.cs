namespace DemoApp;

public class Triangle : ITriangle
{
    private readonly int _height;

    public Triangle(int height) => _height = height;

    public void DrawTriangle()
    {
        var rnd = new Random();

        for (int i = _height; i > 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                Console.ForegroundColor = (ConsoleColor)rnd.Next(1, 15);
                Thread.Sleep(300);
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}

public interface ITriangle
{
    void DrawTriangle();
}