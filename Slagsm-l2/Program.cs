using System.Formats.Asn1;
using System.Reflection.Metadata;
//Create Scavs, Weapons and Bullets

List<Scav> enemies = new();
WeaponLocker locker = new();
BulletLocker locker2 = new();

//Create player and name it Player

Player Player = new Player();
bool OkAnswer = false;
bool InFight = false;

//---------------------------------------------------------------------------------------

//Check for existing Tagilla. If tagilla does not exist and the random number1 ís 10 or below, Add tagilla. Else Add Scav

    if (Random.Shared.Next(101) <= 10000 && enemies.Count(enemy => enemy.name != "Tagilla") == 0)
    {
        enemies.Add(new Tagilla());
    }

    else
    {
        enemies.Add(new Scav());
    }

//---------------------------------------------------------------------------------------

//Disallow empty name

while (OkAnswer == false)
{
    Console.Clear();
    Console.WriteLine("Name your PMC");
    Player.name = Console.ReadLine().Trim();

    if (Player.name.Length >= 1)
    {
        OkAnswer = true;
    }
}

//---------------------------------------------------------------------------------------

//Start dialogue

Console.Clear();
Console.WriteLine($"{Player.name} is equipped with {Player.weapon.Name} loaded with {Player.bullet.Name}");
Console.ReadLine();

//---------------------------------------------------------------------------------------

//Encounter

Console.Clear();
foreach (Scav scav in enemies)
{
    if (scav.isRanged)
    {
        Console.WriteLine($"{Player.name} encountered {scav.name} holding a {scav.weapon.Name} loaded with {scav.bullet.Name}");
    }

    else
    {
        Console.WriteLine($"{Player.name} encountered {scav.name} holding a {scav.meleeWeapon.Name}");
    }
        InFight = true;

}
Console.ReadLine();

//---------------------------------------------------------------------------------------

//While in fight

while(InFight == true && Player.Hp >= 0 && enemies[0].Hp >= 0)
{
    OkAnswer = false;
    while(OkAnswer == false)
    {

        Console.WriteLine("What will you do? Answer with a number!");
        Console.WriteLine($"1. Attack, 2. Defend, 3. Run");
        string answer = Console.ReadLine();

        if (answer == "1")
        {
            Player.Attack(Player, enemies[0]);
            OkAnswer = true;
        }

        else
        {
            Console.WriteLine("Answer with a real option!");
            Console.Clear(); 
        }

    }

        if (Random.Shared.Next(3) <= 1 &&  enemies[0].name != "Tagilla")
        {
            enemies[0].Attack(enemies[0], Player);
        }

        else
        {
            enemies[0].MeleeAttack(enemies[0], Player);
        }

    Console.WriteLine($"{enemies[0].name}'s HP is {enemies[0].Hp} and your Hp is {Player.Hp}");

    Console.ReadLine();
    Console.Clear();
}


//---------------------------------------------------------------------------------------

//Check to see who won the fight

if(Player.Hp <= 0)
{
    
    Console.WriteLine($"{enemies[0].name} 💀 {Player.name} (head, eyes)");
}

else if (enemies[0].Hp <= 0)
{
    Console.WriteLine($"{Player.name} 💀 {enemies[0].name} HEADSHOT (3.4M)");
}

Console.ReadLine();




