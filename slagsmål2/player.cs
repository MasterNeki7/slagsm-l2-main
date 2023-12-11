public class Player
{
    public Weapon weapon = new();
    public Bullets bullet = new();

    public string name;
    public int Hp;

    public Player()
    {
        WeaponLocker weapons = new();
        BulletLocker bullets = new();

        int[] pmcWeapons = {19, 20, 21, 28, 29, 30};
        weapon = weapons.allTheWeapons[pmcWeapons[Random.Shared.Next(pmcWeapons.Length)]];

        bullet = bullets.BulletRandom(weapon);
        
        Hp = 440;
    }

    void Attack()
    {
        if (Random.Shared.Next(101) > weapon.MisfireChance)
        {
            
        }
    }

}