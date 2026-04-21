using UnityEngine;

public class MeleeEnemy : Enemy
{
    [SerializeField]
    private int _weaponDurability;
    public void RepairWeapon()
    {

    }

    public override void Attack()
    {
        Debug.Log("Melee Enemy Attack With Sword");
        _weaponDurability -= 10;
    }
}
