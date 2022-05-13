// Программа проверяет пятизначное число на палиндромом.

Console.WriteLine("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine() ?? "0");
int digit5 = number % 10;
int digit4 = number / 10 % 10;
int digit3 = number / 100 % 10;
int digit2 = number / 1000 % 10;
int digit1 = number / 10000 % 10;
int newnumber = digit5 * 10000 + digit4 * 1000 + digit3 * 100 + digit2 * 10 + digit1;
Console.WriteLine(newnumber);
if (number == newnumber)
{
    Console.WriteLine($"Заданное число является полидромом" );
}
else
{
    Console.WriteLine($"Заданное число не является полидромом");
}

    
