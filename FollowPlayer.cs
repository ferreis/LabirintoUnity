using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject PlayerCamera;
    private Vector3 offset = new Vector3(0, 10, 0);

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = PlayerCamera.transform.position + offset;
    }
}