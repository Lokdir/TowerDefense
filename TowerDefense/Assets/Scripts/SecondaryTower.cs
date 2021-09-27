using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondaryTower : Tower
{
    SecondaryTower()
    {
        attckDmg = 1;
        attckSpeed = 1;
        attckRange = 10;
        lv = 1;
    }

    public int BuildTower(int gold)
    {
        if (gold > CreateCost)
        {
            gold = gold - CreateCost;
        }

        return gold;
    }
}
