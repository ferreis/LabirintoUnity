using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSlime : MonoBehaviour
{
    public float speed = 5;
    private Vector3 _move;

    private void LateUpdate()
    {
        _move =
            new Vector3(Input.GetAxis("Horizontal"),
                0,
                Input.GetAxis("Vertical"));

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