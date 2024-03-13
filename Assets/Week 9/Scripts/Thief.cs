using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thief : Villager
{
    public GameObject DaggerPrefab;
    public Transform DaggerSpawn1;
    public Transform DaggerSpawn2;


    public override ChestType CanOpen()
    {
        return ChestType.Thief;

    }

    protected override void Attack()
    {
        
        base.Attack();

        transform.position = destination;

        Instantiate(DaggerPrefab, DaggerSpawn1.position, DaggerSpawn1.rotation);
        Instantiate(DaggerPrefab, DaggerSpawn2.position, DaggerSpawn2.rotation);
    }

}
