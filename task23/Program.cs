// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

double GetDegree (double numberDegree, double numDegree) // метод возвращает число, возведенное в заданную степень
                                                         // numberDegree - число, которое нужно возвести в степень (6)
                                                         // numDegree - число степени (2)   
                                                         // (6 во 2 степени = 36)
{
    double resultDegree = Math.Pow(numberDegree, numDegree);
    return resultDegree;
}

Console.Write("Введите число N: ");
double N = double.Parse(Console.ReadLine());

Console.Write($"Таблица кубов до {N} -> ");
for (int i = 1; i <= N; i++)
{
  double result = GetDegree(i, 3);
  Console.Write($" {result}  ");
}