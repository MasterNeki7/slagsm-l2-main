﻿List<Scav> enemies = new();
WeaponLocker locker = new();
BulletLocker locker2 = new();

//Create player and name it Player
Player Player = new Player();
bool OkAnswer = false;
bool InFight = false;



//Check for existing Tagilla. If tagilla does not exist and the random number ís 10 or below, Add tagilla. Else Add Scav

    if (Random.Shared.Next(101) <= 10 && enemies.Count(enemy => enemy.name == "Tagilla") == 0)
    {
        enemies.Add(new Tagilla());
    }

    else
    {
        enemies.Add(new Scav());
    }




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



//Start dialogue
Console.Clear();
Console.WriteLine($"{Player.name} is equipped with {Player.weapon.Name} loaded with {Player.bullet.Name}");
Console.ReadLine();



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
        InFight = true;
    }
}
Console.ReadLine();



while(InFight == true && Player.Hp >= 0 && enemies[0].Hp >= 0){

Console.Clear();
Console.WriteLine("What will you do?");
string answer = Console.ReadLine();

Player.Attack(Player, enemies[0]);
enemies[0].Attack(enemies[0], Player);
Console.WriteLine($"{enemies[0].name} HP is {enemies[0].Hp} and you Hp is {Player.Hp}");

Console.ReadLine();
}



if(Player.Hp <= 0)
{
    Console.WriteLine($"{enemies[0].name} ☠︎︎ {Player.name} (head, eyes)");
}

Console.ReadLine();




