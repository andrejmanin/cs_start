using static System.Console;

namespace cs_start
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*try
            {
                int padding = Console.BufferWidth / 2;
                int lineLength = Console.BufferHeight / 2;
                
                Console.SetWindowSize(Console.BufferWidth, Console.BufferHeight);
                Console.SetCursorPosition(0, Console.CursorTop);
                Write("Enter name: ");
                Console.SetCursorPosition(12, Console.CursorTop);
                string? name = ReadLine();
                Console.Clear();
                Console.SetCursorPosition(0, Console.CursorTop);
                Write("Enter age: ");
                Console.SetCursorPosition(12, Console.CursorTop);
                int? age = Convert.ToInt32(ReadLine());
                Console.Clear();
                Console.SetCursorPosition(0, Console.CursorTop);
                WriteLine($"Hello, {name}");
                Console.SetCursorPosition(0, Console.CursorTop);
                WriteLine($"Your age is: {age}");

            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }*/
            while (true)
            {
                
            }

            do
            {
                
            } while (true);

            var list = new List<String>()
            {
                "Hello",
                "World",
            };
            foreach (var VARIABLE in list)
            {
                Console.WriteLine(VARIABLE);
            }
        }
    }
}