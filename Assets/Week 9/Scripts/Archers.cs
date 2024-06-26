using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archers : Villager
{
    public GameObject arrowPrefab;
    public Transform spawnPoint;

    public override string ToString()
    {
        return "I'm bob the archer!;";

    }

    public override ChestType CanOpen()
    {
        return ChestType.Archer;

    }

    protected override void Attack()
    {
        destination = transform.position;
        base.Attack();
        Instantiate(arrowPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
