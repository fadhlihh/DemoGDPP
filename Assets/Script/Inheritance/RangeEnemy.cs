using UnityEngine;

public class RangeEnemy : Enemy
{
    [SerializeField]
    private int _ammunition;
    public void Reload()
    {

    }

    public override void Attack()
    {
        Debug.Log("Range Enemy Attack With Bow");
        _ammunition -= 1;
    }
}
