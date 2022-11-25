using System.Collections;
using System.Collections.Generic;
using System.IO;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Teleport : MonoBehaviour
{
    private int randX;
    private int randZ;
    private bool conseguiuTeleportar = false;


    void Start()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        do
        {
            randX = Random.Range(-20, 20);
            randZ = Random.Range(-20, 20);
            Vector3 Teleport = new Vector3(randX, 0, randZ);

            if ((randX < 20 && randX > -20 && randZ < 20 && randZ > -20) || Input.GetKey("Space"))
            {
                conseguiuTeleportar = true;
                other.transform.position = Teleport;
            }
        } while (conseguiuTeleportar == false);
    }
}