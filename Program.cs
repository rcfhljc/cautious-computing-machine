//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// int numCount = 0;
// Console.Write("Введите количество чисел (от 1 до 100): ");
// int numInput = int.Parse(Console.ReadLine());
// int[] numArray = new int[numInput];
// for (int num = 0; num < numInput; num++)
// {
//     Console.Write("Введите число {0}: ", num + 1);
//     numArray[num] = int.Parse(Console.ReadLine());
// }
// for (int index = 0; index < numInput; index++)
// {
//     if (numArray[index] > 0) numCount++;
// }
// Console.WriteLine("Количество чисел, больше нуля: " + numCount);




//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// Console.WriteLine("Введите коэффициенты первой прямой:");
// var b1 = double.Parse(Console.ReadLine());
// var k1 = double.Parse(Console.ReadLine());
// Console.WriteLine("Введите коэффициент второй прямой:");
// var b2 = double.Parse(Console.ReadLine());
// var k2 = double.Parse(Console.ReadLine());
// double x = -b1 * b2 / (b1 - b2);
// double y = -(b2 * k1 - b1 * k2) / (b1 - b2);
// Console.WriteLine($"Точка пересечения: ({x}, {y})");
