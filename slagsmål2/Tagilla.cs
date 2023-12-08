public class Tagilla : Scav
{

    Random gen = new Random();

    public Weapon weapon = new();
    public int baseHp;

    public int hp;

    public Tagilla()
    {
        {
            name = "Tagilla";
            baseHp = 1220;

            weapon.Name = "DB Superdors 2021 Sledgehammer";
        }
    }

}