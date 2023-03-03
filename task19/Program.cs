// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine());
number = Math.Abs(number);

if ((100000 < number) || (number < 9999))
{
   Console.WriteLine("Ввели не пятизначное число! Повторите ввод!"); 
   
}
else
{
    int digit1 = number/10000%10;
    int digit2 = number/1000%10;
    int digit4 = number/10%10;
    int digit5 = number%10; 

    if (digit1==digit5 && digit2==digit4)
    {
       Console.WriteLine($" {number} является палиндромом"); 
    }
    else
    {
        Console.WriteLine($" {number} не является палиндромом"); 
    }
}
