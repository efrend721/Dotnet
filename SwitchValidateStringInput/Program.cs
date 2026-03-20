namespace SwitchValidateStringInput
{
    class Program
    {
        static void Main()
        {
            string? readInput;
            bool isAccepted = false ;

            Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
            
            do
            {
                readInput = Console.ReadLine();
                if (readInput == "Administrator" || readInput == "Manager" || readInput == "User")
                {
                    Console.WriteLine($"Your Input value {readInput} has been accepted.");
                    isAccepted = true ;
                }
                else
                {
                    Console.WriteLine($"The role name that you entered, {readInput} is not valid. Enter your role name (Administrator, Manager, or User)");
                }

            }while (isAccepted == false);
        }
    }
}
