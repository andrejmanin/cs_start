using static System.Console;

namespace cs_start
{
    public class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                Int32? start = Convert.ToInt16(Console.ReadLine());
                Int32? end = Convert.ToInt16(Console.ReadLine());

                if (start == 0 && end == 0)
                {
                    WriteLine($"{end} is a zero");
                    return;
                }

                if (start > end)
                {
                    (start, end) = (end, start);
                }

                WriteLine();
                for (int i = Convert.ToInt32(start); i <= end; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Write($"{i} ");
                    }
                    WriteLine();
                }
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
            }
        }
    }
}