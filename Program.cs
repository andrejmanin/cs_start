using static System.Console;

namespace cs_start
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                const byte MAX_LENGTH = 6;
                string? input = ReadLine();
                if (input == null || input.Length > MAX_LENGTH)
                {
                    WriteLine(input[..MAX_LENGTH]);
                    return;
                }

                for (var i = input.Length - 1; i >= 0; i--)
                {
                    Write(input[i]);
                }
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
            }
        }
    }
}