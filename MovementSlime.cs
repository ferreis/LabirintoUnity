using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;

public class MovementSlime : MonoBehaviour
{
    public float speed = 5;
    private float horizontalInput;
    private float verticalInput;
    private float turnSpeed = 180;

    public static bool fim = false;
    public static bool _quebrarParede = false;
    public static bool trava = false;
    public float countdown = 0;
    private float delay = 3;
    private void LateUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        if (trava == false && fim == false)
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
                countdown = countdown + 1 * Time.deltaTime;
            }
            else
            {
                trava = false;
                countdown = 0;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Hammer"))
        {
            _quebrarParede = true;
            Destroy(other.gameObject);
        }

        if (_quebrarParede != false && other.gameObject.CompareTag("Wall"))
        {
            Destroy(other.gameObject);
            _quebrarParede = false;
        }

        if (other.gameObject.CompareTag("Hero"))        {
            fim = true;
            MovementHero.fim = true;
            SceneManager.LoadScene("scenes/GameOver");
            Debug.Log("FIM DE JOGO");
            Destroy(gameObject);
        }
    }
}