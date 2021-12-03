// 42. Определить сколько чисел больше 0 введено с клавиатуры

Console.Write("\nУкажите кол-во вводимых чисел: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];
int null_numbers = 0;

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{i + 1} число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
    null_numbers += (array[i] > 0) ? 1 : 0;
}

Console.WriteLine($"\nКол-во чисел большие нуля: {null_numbers}");