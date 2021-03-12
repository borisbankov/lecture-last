using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CM : MonoBehaviour
{
    // Start is called before \the first frame update
    public GameObject cam1;
    public GameObject cam2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            cam1.SetActive(false);
            cam2.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            cam2.SetActive(false);
            cam1.SetActive(true);
        }
    }
}
