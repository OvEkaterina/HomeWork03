// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
 int Data(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int number = Data("Введите пятизначное число : ");
if ((number/10000) == (number%10))
{
    if (((number/1000)%10) == ((number%100)/10))
    {
          Console.WriteLine ("Число " + number + " является полиндромом");
    }
}
else
{
     Console.WriteLine ("Число" + number + "не является полиндромом");
}