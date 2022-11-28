using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parede : MonoBehaviour
{
    

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Hero" && Input.GetKeyDown(KeyCode.Keypad0))
        {
            MovementHero.quebrarParede = false;
            Destroy(gameObject);
            
        }
        if (collision.gameObject.name == "Slime" && Input.GetKeyDown(KeyCode.Space))
        {
            MovementSlime._quebrarParede = false;
            Destroy(gameObject);
        }
    }
}
