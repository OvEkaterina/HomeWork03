// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
 int Data(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int number = Data ("Введите число : ");
int i = 1 ;
while (i <= number)
{
  double result = Math.Pow(i,3);
   i++;
   Console.WriteLine(result);
}
