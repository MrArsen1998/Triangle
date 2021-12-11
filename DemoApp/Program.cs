using DemoApp;

var height = InputManager.GetUserInputNumber();
Triangle triangle = new(height);

var height1 = InputManager.GetUserInputNumber();
Triangle triangle1 = new(height1);

var height2 = InputManager.GetUserInputNumber();
Triangle triangle2 = new(height2);

var height3 = InputManager.GetUserInputNumber();
Triangle triangle3 = new(height3);

var height4 = InputManager.GetUserInputNumber();
Triangle triangle4 = new(height4);

triangle.DrawTriangle();
Console.WriteLine();

triangle1.DrawTriangle();
Console.WriteLine();

triangle2.DrawTriangle();
Console.WriteLine();

triangle3.DrawTriangle();
Console.WriteLine();

triangle4.DrawTriangle();
Console.WriteLine();