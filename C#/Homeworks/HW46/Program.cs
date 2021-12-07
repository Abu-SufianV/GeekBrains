// 46. Написать программу масштабирования фигуры

Console.Write($"\nВведите точки фигуры: ");
string digitsRow = Console.ReadLine();
Console.Write($"\nМножитель масштабирования: ");
int multiply = Convert.ToInt32(Console.ReadLine());
// digitsRow.Replace('(');

string[] digits = digitsRow.Split(new char[] { ' ', '(', ')', ',' }, StringSplitOptions.RemoveEmptyEntries);

Console.Write($"Точки фигуры при масштабе {multiply}: ");
for (int i = 0; i < digits.Length; i = i + 2)
{
    int num_1 = Convert.ToInt32(digits[i]) * multiply;
    int num_2 = Convert.ToInt32(digits[i + 1]) * multiply;
    Console.Write($"({num_1},{num_2}) ");
}
