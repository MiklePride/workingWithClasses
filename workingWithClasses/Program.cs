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
    public string NamePlayer;
    public int AgePlayer;
    public string NameCharacter;
    public string ClassCharacter;
    public int LevelCharacter;

    public Player()
    {
        NamePlayer = "Стёпа";
        AgePlayer = 10;
        NameCharacter = "МамкинНагибатель666";
        ClassCharacter = "Мечник";
        LevelCharacter = 94;
    }

    public void ShowPlayerInformation()
    {
        Console.WriteLine($"Имя игрока - {NamePlayer}" +
            $"\nВозраст игрока - {AgePlayer} лет" +
            $"\nИмя персонажа - {NameCharacter}"+
            $"\nКласс персонажа - {ClassCharacter}" +
            $"\nУровень персонажа - {LevelCharacter}");
    }
}