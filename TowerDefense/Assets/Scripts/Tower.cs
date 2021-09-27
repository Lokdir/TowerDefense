using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower
{
    public SpriteRenderer m_SpriteRenderer;
    public Timer timer;

    public int attckDmg {get; protected set;}
    public float attckSpeed { get; protected set; }
    public float attckRange { get; protected set; }
    public int lv { get; protected set; }

    public const int CreateCost = 25;
    public const int UpgradeCost1=10;
    public const int UpgradeCost2=20;
    public const int UpgradeCost3=30;

    private void Attack(Ennemi target)
    {
        target.hp = target.hp - this.attckDmg;
    }

    public void UpdateAttack(List<Ennemi> ennemiList)
    {
        for (int i = 0; i < ennemiList.Count; i++)
        {
            if (ennemiList[i].m_SpriteRenderer.transform.position.x - this.m_SpriteRenderer.transform.position.x < this.attckRange 
            || ennemiList[i].m_SpriteRenderer.transform.position.y - this.m_SpriteRenderer.transform.position.y < this.attckRange
            || ennemiList[i].m_SpriteRenderer.transform.position.z - this.m_SpriteRenderer.transform.position.z < this.attckRange)
            {
                if (timer.tempTime>=attckSpeed)
                {
                    Attack(ennemiList[i]);
                    timer.tempTime = 0;
                }
            }
        }
    }

    public int UpgradeTower(int gold)
    {
        switch(this.lv){
            case 1:
                if (gold >= UpgradeCost1){
                    gold = gold - UpgradeCost1;
                    this.lv++;
                }
                break;
            case 2:
                if (gold >= UpgradeCost2)
                {
                    gold = gold - UpgradeCost2;
                    this.lv++;
                }
                break;
            case 3:
                if (gold >= UpgradeCost3)
                {
                    gold = gold - UpgradeCost3;
                    this.lv++;
                }
                break;
            default:
                break;
        }

        return gold;
    }

}

