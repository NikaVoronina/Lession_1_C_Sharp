// Семинар 1. 04.08.2022

// Console.WriteLine("Hello, World!");


// 1. Напишите программу, которая на вход принимает число и выдаёт его квадрат (чилсло, умноженное на само себя).

// Console.Clear();

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int sqrt = number * number;
// // number *= number;
// // sqrt = Convert.ToInt32(Math.Pow(number, 2));

// Console.WriteLine("Число в квадрате: " + sqrt);


// 2. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

// Console.Write("Input first namber: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// int square = num2 * num2;
// if (num1 == square)
//     Console.Write("First number is a square of second number");
// else   
//     Console.Write("First number is not a square of second number");


// 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

// Console.Write("Input number of the day: ");
// int day = Convert.ToInt32(Console.ReadLine());

// if (day < 1 || day > 7)
// {
//     Console.Write("Incorrect number");
// }
// else
// {
//     if (day == 1)
//     {
//         Console.Write("Monday");
//     }
//     if (day == 2)
//     {
//         Console.Write("Tuesday");
//     }
// }