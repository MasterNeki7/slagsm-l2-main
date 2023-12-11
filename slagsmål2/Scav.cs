public class Scav : Player
{
    public List<String> Enemies = new List<String>() { "Yuriy Olegovic Gorbachov Petrov IX", "Baltazar Octavius Bartholomew Jr", "Hector Mc Ewen Quintalius Carolus VI", "Robert Aurelius Cesie Cornelius XV", "Oliver",};

    public Scav()
    {
        WeaponLocker weapons = new();
        BulletLocker bullets = new();

        int[] HpAlts = { 220, 330, 440};
        Hp = HpAlts[Random.Shared.Next(HpAlts.Length)];
        name = Enemies[Random.Shared.Next(Enemies.Count)];

        weapon = weapons.WeaponRandom();
        bullet = bullets.BulletRandom(weapon);
    }

}



