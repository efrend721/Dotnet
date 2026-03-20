namespace Switch
{
    class Program
    {
        static void Main()
        {
            
            for (int x = 1 ; x < 101; x++)
            {
                if (x % 3 == 0 && x % 5 == 0)
                {
                    Console.WriteLine($"{x} FizzBuzz ");
                }
                else if (x % 3 == 0)
                {
                    Console.WriteLine($"{x} Fizz ");
                }
                else if (x % 5 == 0)
                {
                    Console.WriteLine($"{x} Buzz");
                }
                else{ 
                Console.WriteLine(x);
                }
            }
        }
    }
}

