// Игра "Black-Jack" 

int[] one_desk_of_cards = new int[] {
    2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 11,
    2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 11,
    2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 11,
    2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 11
};


int[] desks_cards = new int[] { }; // TODO: Есть массив одной колоды "desk_once_cards", на его основе создать новый массив из 6 колод в одном

void shuffle(int[] arr)
/*
Данная функция перемешивает элементы массива в случайном порядке
В качестве аргумента принимает массив, который нужно "перемешать"
*/
{
    Random rand = new Random();

    for (int i = arr.Length - 1; i >= 1; i--)
    {
        int j = rand.Next(i + 1);

        int tmp = arr[j];
        arr[j] = arr[i];
        arr[i] = tmp;
    }
}

string[] add_players(int amount)
{
    string[] players = new string[amount];

    for (int i = 0; i < amount; i++)
    {
        Console.Write($"\nВведите имя {i + 1}-го игрока: ");
        players[i] = Console.ReadLine();
    }

    return players;
}