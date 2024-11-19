using System.Text;
using static System.Console;

namespace cs_start
{
    public class Program
    {
        static void FizzBuzz()
        {
            WriteLine("FizzBuzz");
            do
            {
                WriteLine("Enter number in range [1, 100] (0 to exit): ");
                int input = Convert.ToInt32(ReadLine());
                if (input < 0 || input > 100)
                {
                    WriteLine("Incorrect input");
                    return;
                }

                if (input == 0)
                {
                    WriteLine("Exiting");
                    return;
                }

                if (input % 3 == 0 && input % 5 != 0)
                {
                    WriteLine("Fizz");
                }
                else if (input % 3 != 0 && input % 5 == 0)
                {
                    WriteLine("Buzz");
                }
                else if (input % 3 == 0 && input % 5 == 0)
                {
                    WriteLine("FizzBuzz");
                }
                else
                {
                    WriteLine($"Number {input}");
                }

            } while (true);
        }

        static void Percent()
        {
            WriteLine("Percent");
            int number, percent;
            Write("Enter number: ");
            number = Convert.ToInt32(ReadLine());
            Write("Enter percent: ");
            percent = Convert.ToInt32(ReadLine());

            WriteLine($"Number {(number / 100) * percent}");
        }

        static void Number()
        {
            WriteLine("Number");
            Write("Enter four numbers in line without spaces: ");
            string ?input = ReadLine();
            if (input.Length > 8) // 8 - extra symbol
            {
                WriteLine("Incorrect input");
                return;
            }

            string number = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    continue;
                }
                number += input[i];
            }
            WriteLine(number);
        }

        static void swap()
        {
            WriteLine("Swap");
            int number = Convert.ToInt32(ReadLine());
            if (number.ToString().Length != 6)
            {
                WriteLine("Incorrect input");
                return;
            }
            int first, second;
            Write("Enter first number: ");
            first = Convert.ToInt32(ReadLine());
            Write("Enter second number: ");
            second = Convert.ToInt32(ReadLine());
            if (second < 1 || second > 6 || first < 1 || first > 6)
            {
                WriteLine("Incorrect input");
            }

            first--;
            second--;
            
            char[] digits = number.ToString().ToCharArray();

            (digits[first], digits[second]) = (digits[second], digits[first]);

            string newNumber = new string(digits);

            Console.WriteLine("Result: " + newNumber);
        }

        static void data()
        {
            Console.WriteLine("Data");
            try
            {
                Console.Write("Enter year: ");
                int year = Convert.ToInt32(ReadLine());
                Console.Write("Enter month: ");
                int month = Convert.ToInt32(ReadLine());
                Console.Write("Enter day: ");
                int day = Convert.ToInt32(ReadLine());

                if (month < 1 || month > 12 || day < 1 || day > 31)
                {
                    WriteLine("Incorrect month");
                }

                DateTime date = new DateTime(year, month, day);

                string? s_month = date.ToString("MMMM");
                string seathon;
                if (month == 12 || month >= 1 && month <= 2)
                {
                    seathon = "Winter";
                }
                else if (month >= 3 && month <= 6)
                {
                    seathon = "Spring";
                }
                else if (month >= 7 && month <= 9)
                {
                    seathon = "Summer";
                }
                else
                {
                    seathon = "Autumn";
                }
                Console.WriteLine($"Seathon: {seathon} - {s_month}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void temp()
        {
            int input, c, f;
            do
            {
                Console.WriteLine("------------------ Menu ------------------");
                Console.WriteLine(" 1. Convert from Celsius to Fahrenheit");
                Console.WriteLine(" 2. Convert from Fahrenheit to Celsius");
                Console.WriteLine("\t\t3. Exit");
                Console.WriteLine("------------------------------------------");
                input = Convert.ToInt32(Console.ReadLine());
                if (input == 3)
                {
                    break;
                }

                if (input < 1 || input > 3)
                {
                    Console.WriteLine("Incorrect input");
                } else if (input == 1)
                {
                    Console.WriteLine("Convert from Celsius to Fahrenheit");
                    Console.Write("Enter Celsius: ");
                    c = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Fahrenheit: {c * 1.8 + 32}");
                }
                else
                {
                    Console.WriteLine("Convert from Fahrenheit to Celsius");
                    Console.Write("Enter Fahrenheit: ");
                    f = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Celsius: {(f - 32) * 5 / 9}");
                }
            } while (true);
        }

        static void even()
        {
            Console.WriteLine("Even");
            Console.Write("Enter first number of diapason: ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number of diapason: ");
            int second = Convert.ToInt32(Console.ReadLine());

            if (first > second)
            {
                (first, second) = (second, first);
            }

            for (int i = first; i <= second; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    static void Main(string[] args)
        {
            try
            {
                //FizzBuzz();
                //Percent();
                //Number();
                //swap();
                //data();
                //temp();
                even();
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
            }
        }
    }
}