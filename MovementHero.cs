using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;

public class MovementHero : MonoBehaviour
{
    public float speed = 5;
    private Vector3 _move;
    public static bool trava = false;
    private float delay = 3;
    private float countdown = 0;
    private void LateUpdate()
    {
        _move =
            new Vector3(Input.GetAxis("Horizontal2"),
                0,
                Input.GetAxis("Vertical2"));

        if (trava == false)
        {
            if (
                (Input.GetKey("up") || Input.GetKey("down")) &&
                (Input.GetKey("left") || Input.GetKey("right"))
            )
            {
                transform.Translate(-_move * ((speed / 2) * Time.deltaTime));
            }
            else
            {
                transform.Translate(-_move * (speed * Time.deltaTime));
            }
        }

        if (trava == true)
        {
            if (countdown * Time.deltaTime < delay * Time.deltaTime)
            {
                countdown += 0.01f;
            }
            else
            {
                trava = false;
                countdown = 0;
            }
        }
    }
}