using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.name == "Hero" )
        {
           other.gameObject.transform.Translate(10,0,10);
        }
        if (other.gameObject.name == "Slime" )
        {
            other.gameObject.transform.Translate(10,0,10);
        }

    }
}
