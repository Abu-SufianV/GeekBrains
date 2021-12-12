﻿// 46. Написать программу масштабирования фигуры

Console.Write($"\nВведите точки фигуры: ");
string digitsRow = Console.ReadLine();
Console.Write($"\nМножитель масштабирования: ");
double multiply = Convert.ToDouble(Console.ReadLine());
// digitsRow.Replace('(');

string[] digits = digitsRow.Split(new char[] { ' ', '(', ')', ',' }, StringSplitOptions.RemoveEmptyEntries);

Console.Write($"\nТочки фигуры при масштабе {multiply}: ");
for (int i = 0; i < digits.Length; i = i + 2)
{
    double num_1 = Convert.ToInt32(digits[i]) * multiply;
    double num_2 = Convert.ToInt32(digits[i + 1]) * multiply;
    Console.Write($"\n[{num_1} , {num_2}] ");
}
