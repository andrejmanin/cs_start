using static System.Console;

namespace cs_start
{
    public class Program
    {
        static void Main(string[] args)
        {
            try // Task 2 
            {
                const byte MAX_LENGTH = 5;
                string? input = ReadLine();
                if (input is null || input.Length > MAX_LENGTH)
                {
                    WriteLine(new string('-', MAX_LENGTH));
                    return;
                }
                int min = int.Parse(input[0].ToString()), max = 1, sum = 0, num;
                for (var i = 0; i < input.Length; i++)
                {
                    num = int.Parse(input[i].ToString());
                    if (num < min)
                    {
                        min = num;
                    } else if (num > max)
                    {
                        max = num;
                    }
                    sum += num;
                }
                WriteLine($"Sum: {sum}");
                WriteLine($"Min: {min}");
                WriteLine($"Max: {max}");
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
            }
        }
    }
}