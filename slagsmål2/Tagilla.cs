public class Tagilla : Scav
{
    public Tagilla()
    {
        MeleeLocker melee = new();
        
        isRanged = false;

        name = "Tagilla";
        Hp = 1220;

        meleeWeapon = melee.allTheMelee[0];
    }

}