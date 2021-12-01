// 30. Показать кубы чисел, заканчивающихся на четную цифру

void last_digit_even(int amount)
{
    for (int i = 1; i <= amount; i++)
    {
        if (i % 2 == 0)
        {
            Console.Write(String.Format("{0,7}", Math.Pow(i, 3)));
        }
    }
}

Console.Write("\n\n\nВведите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\n\nПоказать кубы чисел, заканчивающихся на четную цифру от 1 до {num}:");
last_digit_even(num);