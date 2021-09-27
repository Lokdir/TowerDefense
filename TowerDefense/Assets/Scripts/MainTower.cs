using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainTower:Tower
{
    public int hp;
    MainTower()
    {
        hp = 30;
        attckDmg = 1;
        attckSpeed = 1;
        attckRange = 10;
        lv = 1;
    }

}
