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
            damagedPlayer.Hp -= attackingPlayer.bullet.Damage * Random.Shared.Next(3);
            Console.WriteLine($"{attackingPlayer.name} hit {damagedPlayer.name} for {attackingPlayer.bullet.Damage}");
        }

        else
        {
            Console.WriteLine("Your weapon jammed!");
        }
    }

    public void MeleeAttack(Player attackingPlayer, Player damagedPlayer)
    {
        damagedPlayer.Hp -= attackingPlayer.meleeWeapon.Damage;
        Console.WriteLine($"{attackingPlayer.name} hit {damagedPlayer.name} for {damagedPlayer.meleeWeapon.Damage}");
    }

    public void Defend()
    {

    }

    public void Run()
    {

    }

}