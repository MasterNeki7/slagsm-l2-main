List<Scav> enemies = new();
WeaponLocker locker = new();
BulletLocker locker2 = new();
Random generator = new Random();
bool OkAnswer = false;

    //Check for existing Tagilla. If tagilla does not exist and the random number ís 3, Add tagilla. Else Add Scav
    for (int i = 0; i < 1; i++)
    {
        if (generator.Next(4) == 3 && enemies.Count(enemy => enemy.name == "Tagilla") == 0)
        {
            enemies.Add(new Tagilla());
        }

        else
        {
            enemies.Add(new Scav());
        }
    }

    //Create player
    Player Player = new Player();

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

    Console.Clear();
    Console.WriteLine($"{Player.name} is equipped with {Player.weapon.Name} loaded with {Player.bullet.Name}");
    Console.ReadLine();

    Console.Clear();
    Console.WriteLine($"{Player.name} encountered");



    foreach (Scav scav in enemies)
    {
        Console.WriteLine($"{scav.name} holding a {scav.weapon.Name} loaded with {scav.bullet.Name}");
    }



    Console.ReadLine();




