class Program
{
    static void Main(string[] args)
    {
        Player player = new Player();

        player.ShowPlayerInformation();
    }
}

class Player
{
    private string _namePlayer;
    private int _agePlayer;
    private string _nameCharacter;
    private string _classCharacter;
    private int _levelCharacter;

    public Player()
    {
        _namePlayer = "Стёпа";
        _agePlayer = 10;
        _nameCharacter = "МамкинНагибатель666";
        _classCharacter = "Мечник";
        _levelCharacter = 94;
    }

    public void ShowPlayerInformation()
    {
        Console.WriteLine($"Имя игрока - {_namePlayer}" +
            $"\nВозраст игрока - {_agePlayer} лет" +
            $"\nИмя персонажа - {_nameCharacter}"+
            $"\nКласс персонажа - {_classCharacter}" +
            $"\nУровень персонажа - {_levelCharacter}");
    }
}