public class MeleeLocker
{

    List<string> meleeRows = File.ReadAllLines("melee.csv").ToList();

    public List<Melee> allTheMelee = new();



    public MeleeLocker()
    {

        foreach (string weaponRows in meleeRows)
        {
            string[] meleedata = weaponRows.Split(',');

            string name = meleedata[0];
            int.TryParse(meleedata[1], out int damage);

            allTheMelee.Add(new() {Name = name, Damage = damage});
        }

    }

}