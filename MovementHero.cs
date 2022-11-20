using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;

public class MovementHero : MonoBehaviour
{
    public float speed = 5;
    private Vector3 _move;

    private void LateUpdate()
    {
        _move =
            new Vector3(Input.GetAxis("Horizontal2"),
                0,
                Input.GetAxis("Vertical2"));

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
}