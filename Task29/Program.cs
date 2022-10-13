/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и 
выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
ввод элеменетов через консоль (через запятую. использовать метод string.Split())
*/

/*int[] array = {1,2,3,4,5};
string massiv = string.Join(",",array);
Console.WriteLine ($"{massiv}");
*/
  
Console.WriteLine("Введите 8 чисел, разделенные запятой  пробелом");
string text = Console.ReadLine()??"";
string[] array = text.Split(", ");
Console.Write($"{text} -> [");
for (int i=0; i<array.Length-1; i++)
{
   Console.Write($"{array[i]}, ");
}
Console.Write($"{array[array.Length-1]}]");
