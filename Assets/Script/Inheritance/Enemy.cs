using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    protected string _name;
    [SerializeField]
    protected int _hp;

    public void Move()
    {
        Debug.Log("Enemy is moving");
    }

    public virtual void Attack()
    {
        Debug.Log("Enemy is attacking");
    }
}
