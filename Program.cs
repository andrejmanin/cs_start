using static System.Console;

namespace cs_start
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // First variant
                /*WriteLine("Please enter a line (to stop enter after symbol \\n): ");
                int index = 0;
                string? input;
                do
                {
                    index++;
                    input = ReadLine();
                    if (input.Length > 3)
                    {
                        if (input[input.Length - 2] == '\\' && input[input.Length - 1] == 'n')
                        {
                            break;
                        }   
                    }

                    if (input[0] == '\\' && input[1] == 'n')
                    {
                        break;
                    }
                    int length = input.Length;
                    if (index > 1 && input.Length == 3){
                        if(input[1] == '\\' && input[2] == 'n')
                        {
                            break;
                        }
                        WriteLine("Invalid input.");
                        return;
                    }
                } while (true);

                if (index > 1)
                {
                    WriteLine("Your line is vertical");
                    WriteLine($"The symbol you entered was: {input[0]}");
                    WriteLine($"The length your line is: {index}");
                }
                else
                {
                    WriteLine("Your line is horizontal");
                    WriteLine($"The symbol you entered was: {input[0]}");
                    WriteLine($"The length your line is: {input.Length - 2}"); // Last two elements are "\n"
                }*/
                
                // Second variant
                /*Write("Enter a if you want vertical line 'v' or 'h' for horizontal: ");
                char lineChoise = Convert.ToChar(Console.ReadLine());
                Write("Enter length your line: ");
                int lineLength = Convert.ToInt32(Console.ReadLine());
                Write("Enter width your symbol: ");
                char symbol = Convert.ToChar(Console.ReadLine());

                if (lineChoise == 'v')
                {
                    for (int i = 0; i < lineLength; i++)
                    {
                        WriteLine(symbol);
                    }
                } else if (lineChoise == 'h')
                {
                    for (int i = 0; i < lineLength; i++)
                    {
                        Write(symbol);
                    }
                }*/
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
            }
        }
    }
}