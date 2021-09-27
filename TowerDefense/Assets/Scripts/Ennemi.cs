using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemi
{
    MainTower mainTower;
    Timer timer;

    public SpriteRenderer m_SpriteRenderer;
    private int attckDmg;
    private float attckSpeed;
    private float attckRange;
    private float speed;
    public int hp;
    private int goldGiven;

    Ennemi()
    {
        attckDmg = 1;
        attckSpeed = 0.8F;
        attckRange = 5;
        speed = 1;
        hp = 10;
        goldGiven = 2;
    }

    public void CreateEnnemi()
    {

    }

    private void Move()
    {

    }

    private void Attack()
    {
        mainTower.hp=mainTower.hp-this.attckDmg;
    }

    public void UpdateAttack()
    {
        if (this.m_SpriteRenderer.transform.position.x - mainTower.m_SpriteRenderer.transform.position.x < this.attckRange
        || this.m_SpriteRenderer.transform.position.y - mainTower.m_SpriteRenderer.transform.position.y < this.attckRange
        || this.m_SpriteRenderer.transform.position.z - mainTower.m_SpriteRenderer.transform.position.z < this.attckRange)
        {
            if (timer.tempTime >= attckSpeed)
            {
                this.Attack();
                timer.tempTime = 0;
            }
        }
        else {
            this.Move();
        }
    }
}
