using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;

public class MovementSlime : MonoBehaviour
{
    public float speed = 5;
    private float horizontalInput;
    private float verticalInput;
    private float turnSpeed = 90;


    public static bool _quebrarParede = false;
    public static bool trava = false;
    public float countdown = 0;
    private float delay = 3;



    private void LateUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        if (trava == false)
        {
            if (horizontalInput.Equals(verticalInput))
            {
                transform.Translate(Vector3.forward * (Time.deltaTime * speed / 1.5f * verticalInput));
                transform.Rotate(Vector3.up * (Time.deltaTime * turnSpeed * horizontalInput));
            }
            else
            {
                transform.Translate(Vector3.forward * (Time.deltaTime * speed * verticalInput));
                transform.Rotate(Vector3.up * (Time.deltaTime * turnSpeed * horizontalInput));
            }
        }
        else
        {
            if (countdown * Time.deltaTime < delay * Time.deltaTime || trava == true)
            {
                countdown = countdown + 1*Time.deltaTime;
            }
            else
            {
                trava = false;
                countdown = 0;
            }
        }
    }
}