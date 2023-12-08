public class BulletLocker
{

    List<string> ammoRows = File.ReadAllLines("ammo.csv").ToList();

    public List<Bullets> allTheAmmo = new();

    public BulletLocker()
    {

        foreach (string ammoRow in ammoRows)
        {
            string[] ammoData = ammoRow.Split(',');

            string calibre = ammoData[0];
            string name = ammoData[1];
            int.TryParse(ammoData[2], out int damage);

            allTheAmmo.Add(new() { Name = name, Calibre = calibre, Damage = damage });
        }

    }

}
