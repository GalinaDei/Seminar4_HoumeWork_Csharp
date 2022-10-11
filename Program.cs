/*Задача 27: Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

void DigitsSum (int num)
{
  int sum = 0;
  while (num>=1)
  {
    sum = sum + num%10;
    num = num/10;
  } 
  Console.WriteLine($"{sum}");
}
DigitsSum(333);
