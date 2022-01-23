namespace DemoApp;

public class Foo : Comparer<int>
{
    public override int Compare(int x, int y) => x - y;
}