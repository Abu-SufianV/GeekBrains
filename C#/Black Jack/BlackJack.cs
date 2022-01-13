// Игра "Black Jack"

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
    private int cards = 54 * 6;

}