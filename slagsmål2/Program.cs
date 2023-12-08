List<Scav> enemies = new();
WeaponLocker locker = new();
BulletLocker locker2 = new();
Random generator = new Random();


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



    Scav Player = new Scav();
    Console.WriteLine("Name your PMC");
    Player.name = Console.ReadLine();

    Console.Clear();
    Console.WriteLine($"{Player.name} encountered");



    foreach (Scav e in enemies)
    {
        Console.WriteLine($"{e.name} holding a {e.weapon.Name}.");

        foreach (Bullets a in locker2.allTheAmmo.FindAll(ammo => ammo.Calibre == e.weapon.Calibre))
        {
            Console.WriteLine(a.Name, a.Calibre);
        }
    }



    Console.ReadLine();




