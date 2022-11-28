using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuebraMuro : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Hero")
        {
            MovementHero.quebrarParede = true;
        }
        if (other.gameObject.name == "Slime")
        {
            MovementSlime._quebrarParede = true;
        }
        Destroy(gameObject);
    }

 
}
