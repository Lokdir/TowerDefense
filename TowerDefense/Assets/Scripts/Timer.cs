using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float tempTime;

    void Start()
    {
        tempTime=0;
    }

    void Update()
    {
        tempTime = Time.deltaTime;
    }
}
