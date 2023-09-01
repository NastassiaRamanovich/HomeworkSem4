// Задача 40: Напишите программу, которая принимает на вход 
// три числа и проверяет, может ли существовать треугольник с 
// сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
//  меньше суммы двух других сторон.
// Задача 45: Напишите программу, которая будет создавать 
// копию заданного массива с помощью поэлементного копирования.

// Console.WriteLine("Введите число A");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число B");
// int B = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число C");
// int C = Convert.ToInt32(Console.ReadLine());

// if (A < B + C && B < A + C && C < A + B)
// {
//     Console.WriteLine("Треугольник с длинами сторон A, B и C существует");
// }
// else
// {
//     Console.WriteLine("Треугольника с такими сторонами не существует");
// }

int[] array = new int[5];
void FillArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    Console.WriteLine(String.Join(", ", array));
}

FillArray(array);

int[] NewCopyArray(int[] array)
{
    int[] newarray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        newarray[i] = array[i];
    }
    Console.WriteLine(String.Join(", ", newarray));
    return newarray;
}
NewCopyArray(array);