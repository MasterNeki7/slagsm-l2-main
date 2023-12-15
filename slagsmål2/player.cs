public class Player
{
    public Ranged weapon = new();
    public Bullets bullet = new();
    public Melee meleeWeapon = new();

    public bool isRanged = true;

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



    public void Attack(Player attackingPlayer, Player damagedPlayer)
    {
        if (Random.Shared.Next(101) > attackingPlayer.weapon.MisfireChance)
        {
            damagedPlayer.Hp -= attackingPlayer.bullet.Damage;
            Console.WriteLine($"You hit {damagedPlayer.name}");
        }

        else
        {
            Console.WriteLine("Your weapon jammed!");
        }
    }

    public void Defend()
    {

    }

    public void Run()
    {

    }

}