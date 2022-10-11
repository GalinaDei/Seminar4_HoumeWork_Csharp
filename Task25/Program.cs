/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
void Exponentiation(double A, double B)
{
    double res = Math.Pow(A,B);
    Console.Write($"{A}, {B} -> {res}");
}
Exponentiation(-2,2);