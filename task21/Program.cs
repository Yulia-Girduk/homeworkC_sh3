// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

double GetDegree (double numberDegree, double numDegree) // метод возвращает число, возведенное в заданную степень
                                                         // numberDegree - число, которое нужно возвести в степень (6)
                                                         // numDegree - число степени (2)   
                                                         // (6 во 2 степени = 36)
{
    double resultDegree = Math.Pow(numberDegree, numDegree);
    return resultDegree;
}

double GetSqrt (double numberSqrt) //метод возвращает корень квадратный переданного числа
{
    double resultSqrt = Math.Sqrt(numberSqrt);
    return resultSqrt;
}

double GetRound (double numberRound, int n) //метод округление числа number до n знаков после запятой 
                                            //(если округлять до 2-х знаков после запятой5,369 -> 5,37; 5,364 -> 5,36) 
{
    double resultRound = Math.Round(numberRound , n);
    return resultRound;
}

Console.WriteLine("Введите значение координат точки A:");

Console.Write("x1 = ");
double x1 = double.Parse(Console.ReadLine());

Console.Write("y1 = ");
double y1 = double.Parse(Console.ReadLine());

Console.Write("z1 = ");
double z1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите значение координат точки B:");

Console.Write("x2 = ");
double x2 = double.Parse(Console.ReadLine());

Console.Write("y2 = ");
double y2 = double.Parse(Console.ReadLine());

Console.Write("z2 = ");
double z2 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите значение координат точки A: ");
double res = GetDegree((x2-x1), 2) + GetDegree((y2-y1), 2) + GetDegree((z2-z1), 2);

double result = GetSqrt(res);

double distance = GetRound(result, 2);
Console.WriteLine(distance);