// Игра "Black Jack"

namespace Game
{
    class Player
    {
        private string name;
        private int money;

        public Player(string name, int money)
        {
            this.name = name;
            this.money = money;
        }

        public string GetName()
        {
            return this.name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public int GetMoney()
        {
            return this.money;
        }

        public void SetMoney(int money, bool win)
        {
            if (win)
            {
                this.money += money;
            }
            else
            {
                this.money -= money;
            }
        }

    }

    class BlackJack
    {
        private int players_amount = 0;
        private Dictionary<string, int> cards_value = new Dictionary<string, int>()
        {
            {"Два", 2},
            {"Три", 3},
            {"Четыре", 4},
            {"Пять", 5},
            {"Шесть", 6},
            {"Семь", 7},
            {"Восемь", 8},
            {"Девять", 9},
            {"Десять", 10},
            {"Валет", 10},
            {"Дама", 10},
            {"Король", 10},
            {"Туз", 11},

        };

        public int GetCard(string card)
        {
            return this.cards_value[card];
        }

        public void AddPlayer()
        {
            this.players_amount++;
        }

    }
}
