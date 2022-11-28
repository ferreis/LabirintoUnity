using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;

public class MovementHero : MonoBehaviour
{
    public float speed = 5;
    private float horizontalInput;
    private float verticalInput;
    private float turnSpeed = 90;


    public static bool quebrarParede = false;

    public static bool trava = false;
    public float countdown = 0;
    private float delay = 3;

    private void LateUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal2");
        verticalInput = Input.GetAxis("Vertical2");

        if (trava == false)
        {
            if (horizontalInput.Equals(verticalInput))
            {
                transform.Translate(Vector3.forward * (Time.deltaTime * speed * verticalInput));
                transform.Rotate(Vector3.up * (Time.deltaTime * turnSpeed * horizontalInput));
            }
            else
            {
                transform.Translate(Vector3.forward * (Time.deltaTime * speed * verticalInput));
                transform.Rotate(Vector3.up * (Time.deltaTime * turnSpeed * horizontalInput));
            }
        }
        if (trava == true)
        {
            if (countdown * Time.deltaTime <= delay * Time.deltaTime)
            {
                countdown += 1*Time.deltaTime;
            }
            
            else
            {
                trava = false;
                countdown = 0;
            }
        }
    }
}