using System;
using System.IO;
using UnityEngine;

public class MovementHero : MonoBehaviour
{
    public float speed = 5;
    private float horizontalInput;
    private float verticalInput;
    private float turnSpeed = 180;


    public static bool quebrarParede = false;
    public static bool fim = false;
    public static bool trava = false;

    public float countdown = 0;
    private float delay = 3;
    

    private void LateUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal2");
        verticalInput = Input.GetAxis("Vertical2");

        if (trava == false&& fim == false)
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
                countdown += 1 * Time.deltaTime;
            }

            else
            {
                trava = false;
                countdown = 0;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Hammer"))
        {
            quebrarParede = true;
            Destroy(collision.gameObject);
        }
        if (quebrarParede != false && collision.gameObject.CompareTag("Wall"))
        {
            Debug.Log("Teste");
            Destroy(collision.gameObject);
            quebrarParede = false;
        }
    }
    
}