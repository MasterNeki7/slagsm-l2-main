public class Scav : Player
{
    Random gen = new Random();

    public List<String> Enemies = new List<String>() { "Yuriy Olegovic Gorbachov Petrov IX", "Baltazar Octavius Bartholomew Jr", "Hector Mc Ewen Quintalius Carolus VI", "Robert Aurelius Cesie Cornelius XV", "Oliver",  };

    public Scav()
    {
        WeaponLocker locker = new();

        int[] HpAlts = { 220, 330, 440};
        Hp = HpAlts[gen.Next(HpAlts.Length)];

        name = Enemies[gen.Next(Enemies.Count)];
        weapon = locker.WeaponRandom();

       
    }

}



