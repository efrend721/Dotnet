/*
string [] fraudelentOrderIDs = new string[3];

fraudelentOrderIDs[0] = "A123";
fraudelentOrderIDs[1] = "B456";
fraudelentOrderIDs[2] = "C789";
*/

using System.Data.Common;
using System.Net.NetworkInformation;

string[] fraudulentOrderIDs = ["A123", "B456", "C789"];

Console.WriteLine($"First:  \t{fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: \t{fraudulentOrderIDs[1]}");
Console.WriteLine($"Third:  \t{fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders in the array.\n");


string[] names = ["Rowena", "Robin", "Bao"];

foreach (string name in names)
{
    Console.WriteLine(name);
}

int[] inventory = [200, 450, 700, 175, 250];
int sum = 0;

foreach (int items in inventory)
{
    sum += items;
}

Console.WriteLine($"We have {sum} items in inventory.");

Random random = new ();
string[] orderIDs = new string[5];

for (int i = 0; i < orderIDs.Length; i++)
{
    int prefixValue = random.Next(65, 70);
    string prefix = Convert.ToChar(prefixValue).ToString(); ;
    string suffix = random.Next(1, 1000).ToString("000");
    orderIDs[i] = prefix + suffix;
}

foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}

/*
    his Code reverses a message, counts the  number of times
    a particular character appears, then prints the results
    to the  console window.
*/

string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] message = originalMessage.ToCharArray();
Array.Reverse(message);

int letterCount = 0;

foreach (char letter in message)
{
    if (letter == 'o')
    {
        letterCount++;
    }
}

string newMessage = new(message);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {letterCount} times");

