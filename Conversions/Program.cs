string first = "5" ;
string second = "7" ;
int sum = int.Parse(first) + int.Parse(second) ;
Console.WriteLine(sum) ;

Console.WriteLine ("--------------------------------------------") ;

string value1 = "5" ;
string value2 = "5" ;
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2) ;
Console.WriteLine(result) ;

Console.WriteLine ("--------------------------------------------") ;

string value = "102" ;
int result1 = 0 ;

if (int.TryParse(value, out result1))
{
    Console.WriteLine($"Measurement: { result1 } ");
}
else
{
    Console.WriteLine("Unable to report measurement.");
}
Console.WriteLine($"Measurement: (w/ offset): {50 + result1}");


Console.WriteLine ("--------------------------------------------") ;
string [] values = {"12.3", "45", "ABC", "11", "DEF"};
Decimal total = 0m;
string message = "";

foreach (var val in values)
{
    decimal number ;
    if (decimal.TryParse(val, out number))
    {
        total += number ;
    }
    else
    {
        message += val ;
    }
}
Console.WriteLine($"Message : {message}");
Console.WriteLine($"Total : {total}");


