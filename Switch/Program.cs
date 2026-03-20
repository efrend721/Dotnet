using System.Transactions;

namespace Switch
{
    class Program
    {
        static void Main()
        {
            string? readInput;
            int numericValue = 0;
            bool validNumber = false;
            bool isAccepted = false ;
            Console.WriteLine("Enter a nteger value between 5 and 10");
            do
            {
                readInput = Console.ReadLine();
                validNumber = int.TryParse(readInput, out numericValue);

                if (validNumber)
                {
                    if(numericValue >= 5 && numericValue <= 10)
                    {
                        Console.WriteLine($"Your input value {numericValue} has been accepted.") ;
                        isAccepted = true;
                    }
                    else
                    {
                        Console.WriteLine ($"You entered {numericValue}. Please enter a number between 5 and 10.");
                    }
                }
                else
                {
                  Console.WriteLine ("Enter an integer value between 5 and 10")  ;
                }
            }while (isAccepted == false);
        }
    }
}

