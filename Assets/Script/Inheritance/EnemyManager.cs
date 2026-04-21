using System;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField]
    private List<Enemy> _enemyList = new List<Enemy>();

    private void Start()
    {
        _enemyList[1].Attack();
    }
}
