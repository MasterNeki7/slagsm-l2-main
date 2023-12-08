using System.Text.Json;
using System.IO;

public class WeaponLocker
{
    public List<Weapon> weapons = new();

    public WeaponLocker()
    {
        string json = File.ReadAllText("weapons.json");
        weapons = JsonSerializer.Deserialize<List<Weapon>>(json);

        // Console.WriteLine(weapons.Count);
    }

    public Weapon WeaponRandom()
    {
        return weapons[new Random().Next(weapons.Count)];
    }
}
