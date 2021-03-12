using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    public float rotateSpeed = 5.0f;
    private Vector3 offset;



    void Start()
    {
       offset = transform.position - player.position;
    }

    void LateUpdate()
    {
        if (Input.GetMouseButton(1))
        {
            Quaternion angle = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * rotateSpeed, Vector3.up);
            offset = angle * offset;
        }

        transform.position = player.position + offset;
        
        transform.LookAt(player);
    }
}
