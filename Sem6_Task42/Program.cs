// Задача 42: Напишите программу, которая будет 
// преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

Console.Write("Введите десятичное число: ");
int decimalNumber = int.Parse(Console.ReadLine());//45
string binaryString = "";
while (decimalNumber > 0)
{
     int remainder = decimalNumber % 2;
     decimalNumber /= 2;//45 / 2
     binaryString = remainder + binaryString;//  1 + "" 
 }
 Console.WriteLine($"Двоичное представление числа: {binaryString}");