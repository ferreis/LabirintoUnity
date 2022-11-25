using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class travaPlayer : MonoBehaviour
{
    
    
    private void OnTriggerEnter(Collider objAtri)
    {
        if (objAtri.gameObject.name == "Hero")
        {
            MovementSlime.trava = true;
        }
        if (objAtri.gameObject.name == "Slime")
        {
            MovementHero.trava = true;
        }
        Destroy(gameObject);
    }
}
