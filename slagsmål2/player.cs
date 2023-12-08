public class Player
{
    protected Random gen = new Random();

    public Weapon weapon = new();
    public string name;
    public int Hp;

    public Player()
    {
        WeaponLocker locker = new();
        Hp = 440;

    }

}