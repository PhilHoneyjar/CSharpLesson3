// Ввести пятизначное число и проверить является ли оно палиндромом

Console.Write("Input 5 digit number: ");
string? number = Console.ReadLine();

void CheckingNumber(string number)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine("Input number is palindrome");
    }
    else
    {
        Console.WriteLine("Input number isn't palindrome");
    }
}
if (number!.Length == 5)
{
    CheckingNumber(number);
}
else
Console.WriteLine("Input incorrect number");