using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    List<Ennemi> ennemiList;
    List<Tower> towersList;
    int gold;

    // Start is called before the first frame update
    void Start()
    {
        gold = 0;
        ennemiList = new List<Ennemi>();
        towersList = new List<Tower>();
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < ennemiList.Count; i++)
        {
            ennemiList[i].UpdateAttack();
            if (ennemiList[i].hp <= 0)
            {
                gold += ennemiList[i].DestroyEnnemi(gold);
            }
        }
        for (int i = 0; i < towersList.Count; i++)
        {
            towersList[i].UpdateAttack(ennemiList);
        }
    }
}
