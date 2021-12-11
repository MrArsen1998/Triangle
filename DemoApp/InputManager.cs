namespace DemoApp
{
    public class InputManager
    {
        public static int GetUserInputNumber()
        {
            bool success = false;
            int height = 0;

            Console.Write("Please enter a Height: ");

            while (!success)
            {
                string input = Console.ReadLine();
                success = int.TryParse(input, out height);
                if (!success)
                {
                    Console.Clear();
                    Console.Write("Please enter a correct Height: ");
                }
            }

            return height;
        }
    }
}