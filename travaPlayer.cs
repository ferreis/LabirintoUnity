using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class travaPlayer : MonoBehaviour
{
    private float _trava = 3;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Hero")
        {
            
            Vector3 save = new Vector3();
            for (int x = 0; x < _trava; x++)
            {
                save = (gameObject.name == "Slime").GetType().Attributes(_trava);
                other.gameObject;
            }
        }
    }
}
