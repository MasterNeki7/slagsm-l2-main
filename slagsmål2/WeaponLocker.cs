public class WeaponLocker
{

    List<string> weaponRows = File.ReadAllLines("weapons.csv").ToList();

    public List<Weapon> allTheWeapons = new();

    public WeaponLocker()
    {

        foreach (string weaponRows in weaponRows)
        {
            string[] ammoData = weaponRows.Split(',');

            string calibre = ammoData[0];
            string name = ammoData[1];
            int.TryParse(ammoData[2], out int misfireChance);

            allTheWeapons.Add(new() { Name = name, Calibre = calibre, MisfireChance = misfireChance });
        }

    }

    public Weapon WeaponRandom()
    {
        return allTheWeapons[new Random().Next(allTheWeapons.Count)];
    }
}
