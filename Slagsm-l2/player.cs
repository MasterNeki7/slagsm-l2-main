public class Player
{  
    //Ge spelaren ett range vapen, melee vapen och skott.
    public Ranged weapon = new();
    public Bullets bullet = new();
    public Melee meleeWeapon = new();

    public bool isRanged = true;

    public string name;
    public int Hp;
    //Skapa en player
    public Player()
    {
        WeaponLocker weapons = new();
        BulletLocker bullets = new();

        int[] pmcWeapons = {19, 20, 21, 28, 29, 30, 46, 47};
        weapon = weapons.allTheWeapons[pmcWeapons[Random.Shared.Next(pmcWeapons.Length)]];

        bullet = bullets.BulletRandom(weapon);
        Hp = 440;
    }


//Skapa en attack metod som kan användas
    public void Attack(Player attackingPlayer, Player damagedPlayer)
    {   
    //Kolla om vapnet ska få en misfire
        if (Random.Shared.Next(101) > attackingPlayer.weapon.MisfireChance)
        {
            damagedPlayer.Hp -= attackingPlayer.bullet.Damage * Random.Shared.Next(3);
            Console.WriteLine($"{attackingPlayer.name} hit {damagedPlayer.name} for {attackingPlayer.bullet.Damage}");
        }
    //Ge en misfire
        else
        {
            Console.WriteLine("Your weapon jammed!");
        }
    }
    //Attack metod för melee vapen
    public void MeleeAttack(Player attackingPlayer, Player damagedPlayer)
    {
        damagedPlayer.Hp -= attackingPlayer.meleeWeapon.Damage;
        Console.WriteLine($"{attackingPlayer.name} hit {damagedPlayer.name} for {attackingPlayer.meleeWeapon.Damage}");
    }

    public void Heal()
    {
        
    }

    public void Run()
    {

    }

}