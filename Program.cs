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

                int fib, first = 0, second = 1;
                if (start == 0)
                {
                    Write($"{first} {second} ");
                } else if (start == 1)
                {
                    Write($"{second} ");
                }
                do
                {
                    if (first + second > end)
                    {
                        break;
                    }
                    fib = first + second;
                    first = second;
                    second = fib;
                    if (fib >= start)
                    {
                        Write($"{fib} ");   
                    }
                }while(true);
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
            }
        }
    }
}