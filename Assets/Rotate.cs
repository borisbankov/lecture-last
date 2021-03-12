using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.AngleAxis(30, Vector3.right) *
            Quaternion.AngleAxis(60, Vector3.up) *
            Quaternion.AngleAxis(90, Vector3.forward);
    }
}
